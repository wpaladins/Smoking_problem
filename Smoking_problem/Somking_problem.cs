using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smoking_problem
{
    public partial class Somking_problem : Form
    {
        Semaphore sema_tobacco_glue = new Semaphore(0, 1);
        Semaphore sema_tobacco_paper = new Semaphore(0, 1);
        Semaphore sema_parper_glue = new Semaphore(0, 1);

        Random rand = new Random();
        private int key;

        public Somking_problem()
        {
            InitializeComponent();
        }

        private void Somking_problem_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private delegate void dele_smoker1();//delegate方法；
        private delegate void dele_smoker2();
        private delegate void dele_smoker3();
        private delegate void dele_agent();

        private static void by_smoker1()
        {
            return;
        }//被调用方法；
        private static void by_smoker2()
        {
            return;
        }//被调用方法；
        private static void by_smoker3()
        {
            return;
        }//被调用方法；
        private static void by_agent()
        {
            return;
        }//被调用方法；

        private void smoker1_have_tobacco_completed(IAsyncResult asyncResult)
        {
            while(true)
            {
                sema_parper_glue.WaitOne();
                key = 0;
                smoker1.Image = Resource1.ready;
                Thread.Sleep(1000);
                smoker1.Image = Resource1.smoking;
                Thread.Sleep(4000);
                smoker1.Image = null;
                Thread.Sleep(500);
                key = 1;
            }
        }
        private void smoker2_have_glue_completed(IAsyncResult asyncResult)
        {
            while (true)
            {
                sema_tobacco_paper.WaitOne();
                key = 0;
                smoker2.Image = Resource1.ready;
                Thread.Sleep(1000);
                smoker2.Image = Resource1.smoking;
                Thread.Sleep(4000);
                smoker2.Image = null;
                Thread.Sleep(500);
                key = 2;
            }
        }
        private void smoker3_have_parper_completed(IAsyncResult asyncResult)
        {
            while (true)
            {
                sema_tobacco_glue.WaitOne();
                key = 0;
                smoker3.Image = Resource1.ready;
                Thread.Sleep(1000);
                smoker3.Image = Resource1.smoking;
                Thread.Sleep(4000);
                smoker3.Image = null;
                Thread.Sleep(500);
                key = 3;
            }
        }
        private void agent_completed(IAsyncResult asyncResult)
        {
            while(true)
            {
                Thread.Sleep(50);
                if (key == 1)
                {
                    Random rand = new Random();
                    int key_ = rand.Next(2) + 1;
                    if (key_ == 1)
                    {
                        agent_wait();
                        sema_tobacco_glue.Release();
                        continue;
                    }
                    else
                    {
                        agent_wait();
                        sema_tobacco_paper.Release();
                        continue;
                    }
                }
                else if (key == 2)
                {
                    Random rand = new Random();
                    int key_ = rand.Next(2) + 1;
                    if (key_ == 1)
                    {
                        agent_wait();
                        sema_parper_glue.Release();
                        continue;
                    }
                    else
                    {
                        agent_wait();
                        sema_tobacco_glue.Release();
                        continue;
                    }
                }
                else if (key == 3)
                {
                    Random rand = new Random();
                    int key_ = rand.Next(2) + 1;
                    if (key_ == 1)
                    {
                        agent_wait();
                        sema_tobacco_paper.Release();
                        continue;
                    }
                    else
                    {
                        agent_wait();
                        sema_parper_glue.Release();
                        continue;
                    }
                }

            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            key = rand.Next(3) + 1;
            dele_smoker1 smoker1 = by_smoker1;
            dele_smoker2 smoker2 = by_smoker2;
            dele_smoker3 smoker3 = by_smoker3;
            dele_agent agent = by_agent;
            IAsyncResult asyncResult0 = smoker1.BeginInvoke(smoker1_have_tobacco_completed, smoker1);
            IAsyncResult asyncResult1 = smoker2.BeginInvoke(smoker2_have_glue_completed, smoker2);
            IAsyncResult asyncResult2 = smoker3.BeginInvoke(smoker3_have_parper_completed, smoker3);
            IAsyncResult asyncResult3 = agent.BeginInvoke(agent_completed, agent);
            start.Enabled = false;
        }

        private void agent_wait()
        {
            agent.Image = Resource1.put;
            Thread.Sleep(900);
            agent.Image = Resource1.agent_wait;
            Thread.Sleep(100);
        }//图像处理函数；
    }
}
