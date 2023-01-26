using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace JonKenPo
{
    class Game
    {
        public enum Resultado

        {
            Ganhar, Perder, Empatar
        }

        public static Image [] images =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Tesoura.png"),
            Image.FromFile("imagens/Papel.png")
        };

        public Image ImgPC { get; private set; }
        public Image ImgJogador { get; private set; }

        public Resultado Jogar(int jogador)

        {
            int PC = JogadaPC();
            ImgJogador = images[jogador];
            ImgPC = images[PC];

            if (jogador == PC)
            {
                return Resultado.Empatar;
            }
            else if ((jogador == 0 && PC == 1) || (jogador == 1 && PC == 2) || (jogador == 2 && PC == 0))
            {
                return Resultado.Ganhar;

            }
            else 
            {
               return Resultado.Perder;
            }
        }

        private int JogadaPC()
        {
            int mil = DateTime.Now.Millisecond;

            if (mil < 333)
            {
                return 0;
            }
            else if (mil >= 333 && mil< 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }
    }

}