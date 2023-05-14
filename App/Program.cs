using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String data = "Data Source=Localhost;Initial Catalog=QLKS;Persist Security Info=True;User ID=sa;Password=pass";
            inputData(data);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DANGNHAP());
        }
        private static void inputData(String data)
        {
            DANGNHAP.data = data;
            DANGKY.data = data;
            //KHACHHANG
            KH_TTKH.data = data;
            KH_DDV.data = data;
            DP.data = data;
            DVTT.data = data;
            DVT.data = data;
            DDV.data = data;
            KH_TT.data = data;
            KH_DDP.data = data;
            KH_DDDV.data = data;
            CTDV.data = data;
            //NHANVIENDVS
            NVDVS.data = data;
            //DOITAC
            DT_TTTK.data = data;
            DT_KTD.data = data;
            DT_QLDV.data = data;
            //NHANVIENBELLMAN
            NVBM_QLP.data = data;
            NVBM_TNP.data = data;
            //NHANVIENLETAN
            LT_KHM.data = data;
            LT_HD.data = data;
            LT_P.data = data;
            LT_PNP.data = data;
            LT_DV.data = data;
            
        }
    }
}
