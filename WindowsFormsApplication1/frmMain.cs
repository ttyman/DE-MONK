using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskPartitionTest;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            clSingleObjectiveDifferentialEvolution DE;

            try
            {
                DE = new clSingleObjectiveDifferentialEvolution();

                DE.NumberOfProcessors  = Convert.ToInt16(txtProcs.Value);
                DE.NumberOfTasks       = Convert.ToInt16(txtTasks.Value);
                DE.PopulationSize      = Convert.ToInt16(txtPopSize.Value);
                DE.PopulationDimension = DE.NumberOfTasks;
                DE.CPUMaxLoad          = Convert.ToDouble(txtCPULoad.Value);
                DE.MutationFactor      = Convert.ToDouble(txtF.Value);
                DE.Generations         = Convert.ToInt16(txtGenerations.Value);
                DE.CromossomeRate      = Convert.ToDouble(txtCR.Value);

                DE.InitializePopulation(true);

                // update task information on screen
                //grdTaskInf.DataSource = DE.Population.Tasks;
                grdTaskInf.DataSource = DE.Tasks;

                /*
                ** Show population on screen
                */
                // clear grid and add columns
                grdPopulation.Rows.Clear();
                grdPopulation.Columns.Clear();
                for(int i=0; i < DE.NumberOfTasks; i++)
                {
                    grdPopulation.Columns.Add("Task" + i.ToString(), "T" + i.ToString());
                }
                grdPopulation.Columns.Add("Fit1", "Fit1");

                /*
                ** Add rows
                */
                for (int i = 0; i < DE.PopulationSize; i++)
                {

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(grdPopulation);

                    for (int j = 0; j < DE.PopulationDimension; j++)
                    {
                        row.Cells[j].Value = DE.Population.Individuals[i].Tasks[j].ProcessorID;
                        row.Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        grdPopulation.Columns[j].Width = 30;
                    }
                    //row.Cells[ DE.NumberOfTasks ].Value = DE.Population.Individuals[i].FitnessLoadBalanceCalculation( DE.NumberOfProcessors );
                    row.Cells[DE.NumberOfTasks].Value = DE.Population.Individuals[i].FitnessCPUBalance;

                    if ( !DE.Population.Individuals[i].Valid )
                    {
                        //row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }

                    grdPopulation.Rows.Add(row);
                }

                // teste teste
                int idx1, idx2, idx3;
                DE.Pick3IndividualIndexes(out idx1, out idx2, out idx3);

                clIndividual NewDonorVector, PopulationVector; 
                DE.Mutate(out NewDonorVector);
                //DE.Recombination(NewDonorVector,
                //PopulationVector = DE.Population.Individuals[0];

                PopulationVector = DE.Recombination(NewDonorVector, DE.Population.Individuals[0]);

            }
            catch(Exception Error)
            {
                MessageBox.Show("Erro: " + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            /*
            ** set initial values for the main window
            */
            txtPopSize.Value     = 10;
            txtTasks.Value       = 12;
            txtProcs.Value       = 4;
            txtCPULoad.Value     = (Decimal)0.9;
            txtCR.Value          = (Decimal)0.5;
            txtF.Value           = (Decimal)0.5;
            txtGenerations.Value = 100;


        }

        private void ScreenUpdate( clSingleObjectiveDifferentialEvolution DE)
        {

            // update task information on screen
            //grdTaskInf.DataSource = DE.Population.Tasks;
            grdTaskInf.DataSource = DE.Tasks;

            /*
            ** Show population on screen
            */
            // clear grid and add columns
            grdPopulation.Rows.Clear();
            grdPopulation.Columns.Clear();
            for (int i = 0; i < DE.NumberOfTasks; i++)
            {
                grdPopulation.Columns.Add("Task" + i.ToString(), "T" + i.ToString());
            }
            grdPopulation.Columns.Add("Fit1", "Fit1");

            /*
            ** Add rows
            */
            for (int i = 0; i < DE.PopulationSize; i++)
            {

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(grdPopulation);

                for (int j = 0; j < DE.PopulationDimension; j++)
                {
                    row.Cells[j].Value = DE.Population.Individuals[i].Tasks[j].ProcessorID;
                    row.Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    grdPopulation.Columns[j].Width = 30;
                }
                //row.Cells[ DE.NumberOfTasks ].Value = DE.Population.Individuals[i].FitnessLoadBalanceCalculation( DE.NumberOfProcessors );
                row.Cells[DE.NumberOfTasks].Value = DE.Population.Individuals[i].FitnessCPUBalance;

                if (!DE.Population.Individuals[i].Valid)
                {
                    //row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }

                grdPopulation.Rows.Add(row);
            }

        }

        private void cmdStartDE_Click(object sender, EventArgs e)
        {

            clSingleObjectiveDifferentialEvolution DE = null;
            double dblLLowerFitnessValue = 99999.9999;
            double dblLUpperFitnessValue = -99999.9999; ;
            List<double> lstSerie;
            System.IO.StreamWriter logFile = null;

            try
            {

                DE = new clSingleObjectiveDifferentialEvolution();
                lstSerie = new List<double>();
                frmGraphics tela = new frmGraphics();
                logFile = new System.IO.StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\tplog.txt",false);

                DE.NumberOfProcessors  = Convert.ToInt16(txtProcs.Value);
                DE.NumberOfTasks       = Convert.ToInt16(txtTasks.Value);
                DE.PopulationSize      = Convert.ToInt16(txtPopSize.Value);
                DE.PopulationDimension = DE.NumberOfTasks;
                DE.CPUMaxLoad          = Convert.ToDouble(txtCPULoad.Value);
                DE.MutationFactor      = Convert.ToDouble(txtF.Value);
                DE.Generations         = Convert.ToInt16(txtGenerations.Value);
                DE.CromossomeRate      = Convert.ToDouble(txtCR.Value);

                DE.InitializePopulation(true);

                this.ScreenUpdate(DE);
                prbDEProgress.Maximum = DE.Generations;
                prbDEProgress.Value = 0;
                prbDEProgress.Visible = true;


                /*
                ** Start the iteractions 
                */
                for( int interaction=0; interaction < DE.Generations; interaction++ )
                {
                    dblLLowerFitnessValue = 99999.9999;
                    dblLUpperFitnessValue = -99999.9999;

                    // for each individual in the population
                    for(int row=0; row < DE.PopulationSize; row++)
                    {

                        clIndividual NewDonorVector, NewIndividual;
                        DE.Mutate(out NewDonorVector);
                        NewIndividual = DE.Recombination(NewDonorVector, DE.Population.Individuals[row]);

                        // if the New Individual has a better fitness value then the current
                        // population individual, overwrite it.
                        if( NewIndividual.FitnessCPUBalance  <  DE.Population.Individuals[row].FitnessCPUBalance)
                        {
                            DE.Population.Individuals[row] = null;
                            DE.Population.Individuals[row] = NewIndividual;
                        }

                        // get the lower fitness value among the population, for
                        // each iteraction.
                        if (DE.Population.Individuals[row].FitnessCPUBalance < dblLLowerFitnessValue)
                        {
                            dblLLowerFitnessValue = DE.Population.Individuals[row].FitnessCPUBalance;
                        }
                        if(DE.Population.Individuals[row].FitnessCPUBalance > dblLUpperFitnessValue)
                        {
                            dblLUpperFitnessValue = DE.Population.Individuals[row].FitnessCPUBalance;
                        }

                    }

                    // save the best fitness value from the iteraction in a log file.
                    //System.IO.StreamWriter logFile = new System.IO.StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath)+"tplog.txt", true);
                    logFile.WriteLine(dblLLowerFitnessValue.ToString());
                    //logFile.Close();

                    lstSerie.Add(dblLLowerFitnessValue);

                    //this.ScreenUpdate(DE);

                    // teste teste
                    //frmGraphics tela = new frmGraphics();
                    //tela.Visible = true;
                    //tela.UpdateScreen(lstSerie, dblLLowerFitnessValue, dblLUpperFitnessValue);
                    prbDEProgress.Value = interaction;   

                }
                this.ScreenUpdate(DE);
                
                tela.UpdateScreen(lstSerie, dblLLowerFitnessValue, dblLUpperFitnessValue, 0, DE.Generations);
                tela.Visible = true;
                prbDEProgress.Value = 0;
                prbDEProgress.Visible = false;
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error: " + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                logFile.Close();
            }


        }
    }
}
