using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PardalAppPDV
{
    static internal class VisualGraphs
    {
        static public void RoundControl(Control con)
        {
            /* Cria um objeto do tipo GraphicsPath que modifica a forma
          do botão em questão*/
            GraphicsPath forma = new GraphicsPath();
            /* Define como uma elipse o formato do objeto criado
             atribuindo valores para os parâmetros de posição e tamanho*/
            forma.AddEllipse(0, 0, con.Width, con.Height);
            /* Define a região do botão a ser arredondado, ou seja,
            o botão em si*/
            con.Region = new Region(forma);
        }

        static public void RoundBoders(Control con, bool leftTop = true, bool RightTop = true, bool leftBot = true, bool Rightbot = true)
        {
            GraphicsPath Graphs = new GraphicsPath();
            Graphs.AddRectangle(new System.Drawing.Rectangle(1, 1, con.Size.Width, con.Size.Height));

            //Arredondar canto superior esquerdo        
            if (leftTop)
            {
                Graphs.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
                Graphs.AddPie(1, 1, 20, 20, 180, 90);
            }

            //Arredondar canto superior direito
            if (RightTop)
            {
                Graphs.AddRectangle(new System.Drawing.Rectangle(con.Width - 12, 1, 12, 13));
                Graphs.AddPie(con.Width - 24, 1, 24, 26, 270, 90);
            }

            //Arredondar canto inferior esquerdo
            if (leftBot)
            {
                Graphs.AddRectangle(new System.Drawing.Rectangle(1, con.Height - 10, 10, 10));
                Graphs.AddPie(1, con.Height - 20, 20, 20, 90, 90);
            }

            //Arredondar canto inferior direito
            if (Rightbot)
            {
                Graphs.AddRectangle(new System.Drawing.Rectangle(con.Width - 12, con.Height - 13, 13, 13));
                Graphs.AddPie(con.Width - 24, con.Height - 26, 24, 26, 0, 90);
            }

            Graphs.SetMarkers();
            con.Region = new Region(Graphs);
        }
    }
}
