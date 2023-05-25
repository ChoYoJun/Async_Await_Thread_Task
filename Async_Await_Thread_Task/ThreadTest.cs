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

namespace Async_Await_Thread_Task
{
    public partial class ThreadTest : Form
    {
        public ThreadTest()
        {
            InitializeComponent();            
        }
        Thread thread;
        #region //Thread & Thread Pool
        //Thread：容易造成时间 + 空间开销，而且使用不当，容易造成线程过多，导致时间片切换。。。
        //ThreadPool：控制能力比较弱。 做thread的延续，阻塞，取消，超时等等功能。。。。
        //Task 看起来像是一个Thread。。。
        //Task 是在ThreadPool的基础上进行的封装。。。。
        //.net 4.0之后，微软是极力的推荐 Task。。。来作为异步计算。。。
        private void Thread_Start()
        {
            int index = 0;
            thread = new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    try
                    {
                        Thread.Sleep(1000);
                        textBox1.Invoke(new Action(() => {
                            textBox1.AppendText(string.Format("{0},", index++));
                        }));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("{0}, {1}", ex.Message, index));
                    }
                }
            }));
            thread.Start();
        }
        private void ThreadStart_Click(object sender, EventArgs e)
        {
            Thread_Start();
        }

        private void ThreadTest_FormClosed(object sender, FormClosedEventArgs e)
        {
             //thread.Abort();
        }

        private void Suspend_Click(object sender, EventArgs e)
        {
            thread.Suspend();
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            thread.Resume();
        }

        private void Interrupt_Click(object sender, EventArgs e)
        {
            thread.Interrupt();
        }

        private void Abort_Click(object sender, EventArgs e)
        {
            thread.Abort();
        }

        private void Join_Click(object sender, EventArgs e)
        {
            thread.Join();
        }

        private void Threadpool_Click(object sender, EventArgs e)
        {
            //Thread 跟 ThreadPool的区别：threadpool里的线程用完可回收再用
            ThreadPool.QueueUserWorkItem(ShowStr);
            MessageBox.Show("主线程ID：{0}", Thread.CurrentThread.ManagedThreadId.ToString());
        }
        private void ShowStr(object obj)
        {
            MessageBox.Show("CurrentThread ID is : {0}", Thread.CurrentThread.ManagedThreadId.ToString());
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            object state = new object();
            ThreadPool.RegisterWaitForSingleObject(new AutoResetEvent(true), TimerTest, state, 1000, true);//如果设置成false会一直执行
        }
        private void TimerTest(object state,bool timeout)
        {
            MessageBox.Show("CurrentThread ID is : {0}", Thread.CurrentThread.ManagedThreadId.ToString());
        }
        #endregion

        #region //Task
        //Task 启动方式：实例化、TaskFactory、Task.Run、Task.RunSynchronously(同步)

        private void NewTask_Click(object sender, EventArgs e)
        {
            Task task = new Task(() =>
            {
                MessageBox.Show("123");
            });
            task.Start();
        }

        private void TaskFactory_Click(object sender, EventArgs e)
        {
            var task = Task.Factory.StartNew(() =>
            {
                MessageBox.Show("123");
            });
        }

        private void TaskRun_Click(object sender, EventArgs e)
        {
            var task = Task.Run(() =>
            {
                MessageBox.Show("123");
            });
        }

        private void Synchronously_Click(object sender, EventArgs e)
        {
            var task = new Task(() =>
            {
                MessageBox.Show("123");
            });
            task.RunSynchronously();
        }

        //Task 常用阻塞（Wait,WaitAll,WaitAny,WhenAll,WhenAny）、延续方法（ContinueWith）
        private void TaskWaitAll_Click(object sender, EventArgs e)
        {
            Task task1 = new Task(() =>
            {
                MessageBox.Show("线程1");
            });
            task1.Start();
            Task task2 = new Task(() =>
            {
                MessageBox.Show("线程2");
            });
            task2.Start();
            Task.WhenAll(task1, task2).ContinueWith(t =>
            {
                MessageBox.Show("线程3");
            });
        }

        private void TaskWaitAny_Click(object sender, EventArgs e)
        {
            Task task1 = new Task(() =>
            {
                MessageBox.Show("线程1");
            });
            task1.Start();
            Task task2 = new Task(() =>
            {
                MessageBox.Show("线程2");
            });
            task2.Start();
            Task.WhenAny(task1, task2).ContinueWith(t =>
            {
                MessageBox.Show("线程3");
            });
        }

        #endregion

        private void TaskCreationOptions_Click(object sender, EventArgs e)
        {
            Task task = new Task(() =>
            {
                Task task1 = new Task(() =>
                {
                    MessageBox.Show("task1");
                }, System.Threading.Tasks.TaskCreationOptions.AttachedToParent); //建立了父子关系。。。 父任务想要继续执行，必须等待子任务执行完毕。。。。
                Task task2 = new Task(() =>
                {
                    MessageBox.Show("task2");
                }, System.Threading.Tasks.TaskCreationOptions.AttachedToParent);
            });
            task.Start();
            task.Wait();//task.WaitAll(task1,task2);
            MessageBox.Show("Task3");
        }

        private void DenyChildAttach_Click(object sender, EventArgs e)
        {
            Task task = new Task(() =>
            {
                Task task1 = new Task(() =>
                {
                    MessageBox.Show("task1");
                }, System.Threading.Tasks.TaskCreationOptions.AttachedToParent);
                Task task2 = new Task(() =>
                {
                    MessageBox.Show("task2");
                }, System.Threading.Tasks.TaskCreationOptions.AttachedToParent);
                task1.Start();
                task2.Start();
            }, System.Threading.Tasks.TaskCreationOptions.DenyChildAttach); //不让子任务附加到父任务上去。。
            task.Start();
            task.Wait();  //task.WaitAll(task1,task2);
            MessageBox.Show("task");
        }
    }
}
