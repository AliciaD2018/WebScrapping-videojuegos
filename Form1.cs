using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }
        //Carga las drirecciones del txt en un arreglo de String
        static HtmlWeb n = new HtmlWeb();
        static HtmlWeb n2 = new HtmlWeb();
        static HtmlAgilityPack.HtmlDocument dataGame = new HtmlAgilityPack.HtmlDocument();
        static HtmlAgilityPack.HtmlDocument dataCritica = new HtmlAgilityPack.HtmlDocument();
        static string[] pe = new string[5];
        static string[] pe2 = new string[5];
        //Carga las drirecciones del txt en un arreglo de String
        public static string[] lectura()
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\50684\Desktop\ListaSteam.txt");
            return text;
        }
        //Carga las drirecciones del txt en un arreglo de String
        public static string[] lecturaPS()
        {
            string[] text2 = System.IO.File.ReadAllLines(@"C:\Users\50684\Desktop\ListaPS.txt");
            return text2;
        }
        //Carga las drirecciones del txt en un arreglo de String
        public static string[] leerCritica()
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\50684\Desktop\Critica.txt");
            return text;
        }
        //Carga las drirecciones del txt en un arreglo de String
        public static string[] leerTiempo()
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\50684\Desktop\Duracion.txt");
            return text;
        }

        //Busca en la pagina los descuentos del juego 
        public static string descuento(HtmlAgilityPack.HtmlDocument c)
        {

            foreach (var nodo in c.DocumentNode.CssSelect(".discount_pct"))
            {
                return nodo.InnerText;
            }
            return "0%";

        }
        //Busca en la pagina el Nombre del juego
        public static string nombre(HtmlAgilityPack.HtmlDocument c)
        {

            foreach (var nodo in c.DocumentNode.CssSelect(".apphub_AppName"))
            {
                return nodo.InnerText;
            }
            return "";

        }
        //Busca en la pagina los precios del juego
        public static string precio(HtmlAgilityPack.HtmlDocument c)
        {

            foreach (var nodo in c.DocumentNode.CssSelect(".discount_original_price"))
            {
                return nodo.InnerText;
            }
            return "------";

        }

        //Busca en la pagina los precios con descuentos del juego
        public static string precioConD(HtmlAgilityPack.HtmlDocument c)
        {
            foreach (var nodo in c.DocumentNode.CssSelect(".game_purchase_action_bg"))
            {
                nodo.InnerText.Trim();
                return nodo.InnerText.Remove(40);
            }
            {
                foreach (var nodo in c.DocumentNode.CssSelect(".discount_final_price"))
                {
                    return nodo.InnerText;
                }
            }
            return "";
        }
        public static string critica(HtmlAgilityPack.HtmlDocument c)
        {

            foreach (var nodo in c.DocumentNode.CssSelect(".game_area_metascore"))
            {
                return nodo.InnerText;
            }
            return "";
        }
        public static string[] datosParalelo(HtmlAgilityPack.HtmlDocument c)
        {
            Parallel.Invoke(() =>
            {
                pe[3] = precioConD(c);

            }, () =>
            {

                pe[2] = precio(c);
            },
            () =>
            {
                pe[0] = nombre(c);

            }, () =>
            {
                pe[1] = descuento(c);

            }, () =>
            {

                pe[4] = critica(c);
            }
            );

            return pe;
        }
        

        //Busca en la pagina los descuentos del juego 
        public static string descuentoPS(HtmlAgilityPack.HtmlDocument c)
        {

            foreach (var nodo in c.DocumentNode.CssSelect(".discount-badge__message"))
            {
                return nodo.InnerText;
            }
            return "0%";

        }
        //Busca en la pagina el Nombre del juego
        public static string nombrePS(HtmlAgilityPack.HtmlDocument c)
        {

            foreach (var nodo in c.DocumentNode.CssSelect(".pdp__title"))
            {
                return nodo.InnerText;
            }
            return "";

        }
        //Busca en la pagina los precios del juego
        public static string precioPS(HtmlAgilityPack.HtmlDocument c)
        {

            foreach (var nodo in c.DocumentNode.CssSelect(".price-display__strikethrough"))
            {
                return nodo.InnerText.Trim();
            }
            return "-----";

        }

        //Busca en la pagina los precios con descuentos del juego
        public static string precioConDPS(HtmlAgilityPack.HtmlDocument c)
        {

            foreach (var nodo in c.DocumentNode.CssSelect(".price-display__price"))
            {
                return nodo.InnerText;
            }
            return "";
        }
        public static string criticaPS(HtmlAgilityPack.HtmlDocument c)
        {

            foreach (var nodo in c.DocumentNode.CssSelect(".metascore_anchor"))
            {
                return nodo.InnerText.Trim();
            }
            return "";
        }
        public static string[] datosParaleloPS(HtmlAgilityPack.HtmlDocument litaTXT, HtmlAgilityPack.HtmlDocument criticaMM)
        {
            Parallel.Invoke(() =>
            {

                pe2[3] = precioConDPS(litaTXT);

            }, () =>
            {
                pe2[2] = precioPS(litaTXT);
            },
            () =>
            {
                pe2[0] = nombrePS(litaTXT);
            }, () =>
            {
                pe2[1] = descuentoPS(litaTXT);

            }, () =>
            {
                pe2[4] = criticaPS(criticaMM);
            }
            );

            return pe2;
        }
        //INICIO DE BOTONES

        private void button1_Click(object sender, EventArgs e)
        {

            textejecucionSteam.Text = "";
            grillaSteam.Rows.Clear();

            Stopwatch v = Stopwatch.StartNew();

            for (int x = 0; x < lectura().Length; x++)
            {
                dataGame = n.Load(lectura()[x]);
                grillaSteam.Rows.Add(datosParalelo(dataGame)[0], datosParalelo(dataGame)[1], datosParalelo(dataGame)[2], datosParalelo(dataGame)[3], datosParalelo(dataGame)[4], "duracion null");
                pe[2] = "";
                pe[3] = "";
                pe[1] = "";
            }
            v.Stop();
            textejecucionSteam.Text = ("Time taken: {0}s", v.Elapsed.TotalSeconds)+"";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textejecucionPlay.Text = "";
            grillaPlay.Rows.Clear();

            Stopwatch v = Stopwatch.StartNew();

            for (int x = 0; x < lecturaPS().Length; x++)
            {
                dataGame = n.Load(lecturaPS()[x]);
                dataCritica = n2.Load(leerCritica()[x]);
                grillaPlay.Rows.Add(datosParaleloPS(dataGame, dataCritica)[0], datosParaleloPS(dataGame, dataCritica)[1],
                    datosParaleloPS(dataGame, dataCritica)[2], datosParaleloPS(dataGame, dataCritica)[3],
                    datosParaleloPS(dataGame, dataCritica)[4], "duracion null");
                pe2[2] = "";
                pe2[3] = "";
                pe2[1] = "";
            }
            v.Stop();
            textejecucionPlay.Text = ("Time taken: {0}s" + v.Elapsed.TotalSeconds)+"";
        }

        private void btn_paralela_Click(object sender, EventArgs e)
        {
            HtmlWeb z = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            textejecucionPlay.Text = "";
            textejecucionSteam.Text = "";
            grillaSteam.Rows.Clear();
            grillaSteam.Refresh();
            grillaPlay.Rows.Clear();
            grillaPlay.Refresh();

            Stopwatch t = Stopwatch.StartNew();
            Parallel.Invoke(() =>
            { //inicio 1 bloque          

                for (int x = 0; x < lectura().Length; x++)
                {
                    doc = n.Load(lectura()[x]);
                    grillaSteam.Rows.Add(datosParalelo(doc)[0], datosParalelo(doc)[1], datosParalelo(doc)[2],
                    datosParalelo(doc)[3], datosParalelo(doc)[4], "duracion null");

                    pe[2] = "";
                    pe[3] = "";
                    pe[1] = "";
                }
               

            },//cierre 1 bloque
            () =>
            {

                for (int x = 0; x < lecturaPS().Length; x++)
                {
                    dataGame = z.Load(lecturaPS()[x]);
                    dataCritica = n2.Load(leerCritica()[x]);
                    grillaPlay.Rows.Add(datosParaleloPS(dataGame, dataCritica)[0], datosParaleloPS(dataGame, dataCritica)[1],
                    datosParaleloPS(dataGame, dataCritica)[2], datosParaleloPS(dataGame, dataCritica)[3],
                    datosParaleloPS(dataGame, dataCritica)[4], "duracion null");

                    pe2[2] = "";
                    pe2[3] = "";
                    pe2[1] = "";
                }
                
            });
            t.Stop();
            textejecucionPlay.Text = ("Time taken: {0}s" + t.Elapsed.TotalSeconds) + "";
            textejecucionSteam.Text = ("Time taken: {0}s", t.Elapsed.TotalSeconds) + "";
        }
    }
}
