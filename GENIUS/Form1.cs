using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GENIUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_level.Text = "Nível: " + QntdCores;
        }





        int[] sequencia = new int[15];
        int QntdCores = 0;
        Random aleatorio = new Random();
        int[] sequenciaEscolhida = new int [15];
        int acertou = 0;




        
        private void button5_Click(object sender, EventArgs e)
        {
           
            QntdCores++;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            button6.Enabled = false;
            button5.Enabled = false;
            lbl_level.Text = "Nível: " + QntdCores;



            for (int i = 0; i < QntdCores; i++)
            {
                sequencia[i] = aleatorio.Next(1,5);
            }

            for (int i = 0; i < QntdCores; i++)
            {

                if (sequencia[i] == 1)
                {
                    
                   
                    Task.Delay(500).Wait();
                    button1.BackColor = Color.Red;
                    Task.Delay(1000).Wait();
                    button1.BackColor = Color.LightCoral;
                   
                    continue;
                    
                }
                if (sequencia[i] == 2)
                {
                    
                   
                    Task.Delay(500).Wait();
                    button2.BackColor = Color.Blue;
                    Task.Delay(1000).Wait();
                    button2.BackColor = Color.LightSteelBlue;
                    
                    continue;

                }
                if (sequencia[i] == 3)
                {
                   
                    
                    Task.Delay(500).Wait();
                    button3.BackColor = Color.Yellow;
                    Task.Delay(1000).Wait();
                    button3.BackColor = Color.PaleGoldenrod;
                   
                    continue;
                }
                if (sequencia[i] == 4)
                {
                   
                   
                    Task.Delay(500).Wait();
                    button4.BackColor = Color.Green;
                    Task.Delay(1000).Wait();
                    button4.BackColor = Color.DarkSeaGreen;
                    
                    continue;
                }

                 

            }
            button6.Enabled = true;
           

        }






        private void button4_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < QntdCores; i++)
            {
                if (sequenciaEscolhida[i] == 0)
                {
                    sequenciaEscolhida[i] = 4;
                    break;
                }
            }
            button4.BackColor = Color.Green;
            Task.Delay(200).Wait();
            button4.BackColor = Color.DarkSeaGreen;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < QntdCores; i++)
            {
                if (sequenciaEscolhida[i] == 0)
                {
                    sequenciaEscolhida[i] = 1;
                    break;
                }
            }
            button1.BackColor = Color.Red;
            Task.Delay(200).Wait();
            button1.BackColor = Color.LightCoral;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < QntdCores; i++)
            {
                if (sequenciaEscolhida[i] == 0)
                {
                    sequenciaEscolhida[i] = 2;
                    break;
                }
            }
            button2.BackColor = Color.Blue;
            Task.Delay(200).Wait();
            button2.BackColor = Color.LightSteelBlue;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < QntdCores; i++)
            {
                if (sequenciaEscolhida[i] == 0)
                {
                    sequenciaEscolhida[i] = 3;
                    break;
                }
            }
            button3.BackColor = Color.Yellow;
            Task.Delay(200).Wait();
            button3.BackColor = Color.PaleGoldenrod;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            for (int i = 0; i < QntdCores; i++)
            {
                if (sequenciaEscolhida[i] == sequencia[i])
                {
                    acertou++;
                }
            }
                if (acertou == QntdCores)
                {


                    MessageBox.Show("Parabéns.Você passou de nível!");
                    lbl_level.Text = "Nível: " + QntdCores;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button6.Enabled = false;
                    button5.Text = "Próximo nível";
                    acertou = 0;

                    for (int j = 0; j < QntdCores; j++)
                    {
                        sequencia[j] = 0;
                        sequenciaEscolhida[j] = 0;

                    }
                    


                }




                else
                {
                    MessageBox.Show("Você errou a sequência!");
                    
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button6.Enabled = false;
                    lbl_level.Text = "Nível: " + QntdCores;
                    acertou = 0;
                button5.Text = "INICIAR";

                    for (int k = 0; k < QntdCores; k++)
                    {
                        sequencia[k] = 0;
                        sequenciaEscolhida[k] = 0;
                    }
                QntdCores = 0;

            }
            
        }

        
    }
    }

