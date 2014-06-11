using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net; //SONRADAN EKLENDİ
using System.Text;
using System.Threading; //SONRADAN EKLENDİ
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNormalString_Click(object sender, EventArgs e)
        {
            DownloadData(); //DownloadData metodunu çağırıyoruz...
        }

        private async void btnAsyncString_Click(object sender, EventArgs e) //Async keyword'üne dikkat!
        {
            string getdata = await DownloadDataAsync(); //await keyword'üne dikkat!
            MessageBox.Show(getdata);
        }

        private void DownloadData()
        {
            WebClient wc = new WebClient(); //WebClient Sınıfından yeni bir WebClient nesnesi türetiliyor...
            string data = wc.DownloadString("http://w3schools.com");
            //Ürettiğimiz wc isimli nesnenin DownloadString metoduyla w3schools kaynağındaki html kodlarını çekip değişkene aktarıyoruz
            MessageBox.Show(data); 

        }

        async Task<string> DownloadDataAsync() //DownloadDataAsync Task'inin asenkron olduğunu async keyword'ü ile belirtiyoruz. Asenkron kullanmak istediğimiz için Task oluşturduk.
        {
            WebClient wc = new WebClient(); //WebClient Sınıfından yeni bir WebClient nesnesi türetiliyor...
            string data = await wc.DownloadStringTaskAsync("http://w3schools.com");
            //Ürettiğimiz wc isimli nesnenin DownloadString metoduyla w3schools kaynağındaki html kodlarını çekip değişkene aktarıyoruz
            return data; //Veri kaynağından çektiği verileri tekrar döndürüyor. Böylece bu metodu çağıran yere bu bilgi ulaşmış oluyor.
        }

        private void btnNormalPicture_Click(object sender, EventArgs e) //Normal metod.
        {
            pictureBox1.Load("http://cdn.memegenerator.net/instances/500x/34330403.jpg");
        }

        private void btnAsyncPicture_Click(object sender, EventArgs e) //Async keyword'üne dikkat
        {
            pictureBox1.LoadAsync("http://cdn.memegenerator.net/instances/500x/34330403.jpg"); //Hazır bir async metod.
        }

        private void btnNormalSleep_Click(object sender, EventArgs e)
        {
            NormalMessage(); //NormalMessage metodunu çağırıyoruz...
        }

        private async void btnAsyncSleep_Click(object sender, EventArgs e)
        {
            await ShowAsyncMessage(); //ShowAsyncMessage metodunu asenkron olarak çağırıyoruz...
        }

        async Task ShowAsyncMessage() //async keyword'ü ile yeni bir Task türetiyoruz...
        {
            await Task.Run(() => Thread.Sleep(5000)); //5000 milisaniye işlemi durduruyoruz...
            MessageBox.Show("İşlem Tamamlandı");
        }

        private void NormalMessage() //Normal mesaj gösteren metod
        {
            Thread.Sleep(5000);
            MessageBox.Show("İşlem Tamamlandı");
        }
    }
}
