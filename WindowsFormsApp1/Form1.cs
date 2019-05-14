using Askerlik.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            AskerlikDbEntities db = new AskerlikDbEntities();
            db.Database.CreateIfNotExists();

            Kisla kisla = db.Kisla.Add(new Kisla()
            {
                Adi = "Ankara",
                Kapasite = 10,
                Oncelik = 0,
                AktifMi = true,
            });

            Asker asker = new Asker();

            asker.Id = Guid.NewGuid();
            asker.Name = "Hede";
           
              
            db.SaveChanges();            

            Kisla ustKisla = db.Kisla.Where(a => a.KislaId == kisla.KislaId).SingleOrDefault();
            ustKisla.UstKategoriId = kisla.KislaId;

            db.Entry(ustKisla).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
            
            //   ServiceReference1.KPSPublicSoapClient client = new ServiceReference1.KPSPublicSoapClient();
            //bool hede=   client.TCKimlikNoDogrula(12345678910, "melike", "memis", 1989);
        }
    }
}
