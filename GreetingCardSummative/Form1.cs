using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

/// <summary>
/// Created by Calem Christopher McTavish-Giagnocavo
/// September 2019
/// Birthday Card
/// </summary>

namespace GreetingCardSummative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Graphics Objects
            Graphics g = this.CreateGraphics();

            Font titlefont = new Font("Monotype Corsiva", 45, FontStyle.Italic);

            SolidBrush titlefontbrush = new SolidBrush(Color.DarkRed);

            SolidBrush cakebrush = new SolidBrush(Color.Chocolate);
            SolidBrush cakebrush2 = new SolidBrush(Color.DarkSlateBlue);

            SolidBrush candlebrush1 = new SolidBrush(Color.OrangeRed);
            SolidBrush candlebrush2 = new SolidBrush(Color.LawnGreen);
            SolidBrush candlebrush3 = new SolidBrush(Color.DodgerBlue);
            SolidBrush candlebrush4 = new SolidBrush(Color.Gold);

            SolidBrush candleflame = new SolidBrush(Color.Orange);

            SolidBrush frecklebrush = new SolidBrush(Color.WhiteSmoke);

            SolidBrush bubblebrush = new SolidBrush(Color.LightBlue);

            //Front of card
            g.Clear(Color.Khaki);
           
            //text
            g.DrawString("HAPPY BIRTHDAY", titlefont, titlefontbrush, 150, 40);

            //cake body
            g.FillRectangle(cakebrush, 280, 280, 260, 110);
            g.FillRectangle(cakebrush2, 280, 230, 260, 80);

            //Frosting edges
            g.FillEllipse(cakebrush2, 280, 295, 20, 20);
            g.FillEllipse(cakebrush2, 300, 295, 20, 20);
            g.FillEllipse(cakebrush2, 320, 295, 20, 20);
            g.FillEllipse(cakebrush2, 340, 295, 20, 20);
            g.FillEllipse(cakebrush2, 360, 295, 20, 20);
            g.FillEllipse(cakebrush2, 380, 295, 20, 20);
            g.FillEllipse(cakebrush2, 400, 295, 20, 20);
            g.FillEllipse(cakebrush2, 420, 295, 20, 20);
            g.FillEllipse(cakebrush2, 440, 295, 20, 20);
            g.FillEllipse(cakebrush2, 460, 295, 20, 20);
            g.FillEllipse(cakebrush2, 480, 295, 20, 20);
            g.FillEllipse(cakebrush2, 500, 295, 20, 20);
            g.FillEllipse(cakebrush2, 520, 295, 20, 20);

            //Frosting Freckles
            g.FillEllipse(frecklebrush, 405, 300, 5, 5);
            g.FillEllipse(frecklebrush, 285, 260, 5, 5);
            g.FillEllipse(frecklebrush, 297, 290, 5, 5);
            g.FillEllipse(frecklebrush, 306, 270, 5, 5);
            g.FillEllipse(frecklebrush, 312, 300, 5, 5);
            g.FillEllipse(frecklebrush, 313, 252, 5, 5);
            g.FillEllipse(frecklebrush, 331, 275, 5, 5);
            g.FillEllipse(frecklebrush, 460, 300, 5, 5);
            g.FillEllipse(frecklebrush, 340, 260, 5, 5);
            g.FillEllipse(frecklebrush, 352, 290, 5, 5);
            g.FillEllipse(frecklebrush, 361, 270, 5, 5);
            g.FillEllipse(frecklebrush, 367, 300, 5, 5);
            g.FillEllipse(frecklebrush, 368, 252, 5, 5);
            g.FillEllipse(frecklebrush, 386, 275, 5, 5);
            g.FillEllipse(frecklebrush, 515, 300, 5, 5);
            g.FillEllipse(frecklebrush, 395, 260, 5, 5);
            g.FillEllipse(frecklebrush, 407, 290, 5, 5);
            g.FillEllipse(frecklebrush, 416, 270, 5, 5);
            g.FillEllipse(frecklebrush, 422, 300, 5, 5);
            g.FillEllipse(frecklebrush, 423, 252, 5, 5);
            g.FillEllipse(frecklebrush, 441, 275, 5, 5);
            g.FillEllipse(frecklebrush, 450, 260, 5, 5);
            g.FillEllipse(frecklebrush, 462, 290, 5, 5);
            g.FillEllipse(frecklebrush, 471, 270, 5, 5);
            g.FillEllipse(frecklebrush, 477, 300, 5, 5);
            g.FillEllipse(frecklebrush, 478, 252, 5, 5);
            g.FillEllipse(frecklebrush, 496, 275, 5, 5);
            g.FillEllipse(frecklebrush, 505, 260, 5, 5);
            g.FillEllipse(frecklebrush, 517, 290, 5, 5);
            g.FillEllipse(frecklebrush, 526, 270, 5, 5);
            g.FillEllipse(frecklebrush, 532, 300, 5, 5);

            //candle flames
            g.FillEllipse(candleflame, 291, 212, 10, 15);
            g.FillEllipse(candleflame, 320, 235, 10, 15);
            g.FillEllipse(candleflame, 340, 218, 10, 15);
            g.FillEllipse(candleflame, 364, 209, 10, 15);
            g.FillEllipse(candleflame, 380, 227, 10, 15);
            g.FillEllipse(candleflame, 400, 216, 10, 15);
            g.FillEllipse(candleflame, 419, 205, 10, 15);
            g.FillEllipse(candleflame, 436, 230, 10, 15);
            g.FillEllipse(candleflame, 457, 225, 10, 15);
            g.FillEllipse(candleflame, 481, 215, 10, 15);
            g.FillEllipse(candleflame, 500, 224, 10, 15);
            g.FillEllipse(candleflame, 516, 210, 10, 15);

            //candles
            g.FillRectangle(candlebrush1, 291, 222, 10, 40);
            g.FillRectangle(candlebrush2, 320, 245, 10, 40);
            g.FillRectangle(candlebrush3, 340, 228, 10, 40);
            g.FillRectangle(candlebrush1, 364, 219, 10, 40);
            g.FillRectangle(candlebrush4, 380, 237, 10, 40);
            g.FillRectangle(candlebrush3, 400, 226, 10, 40);
            g.FillRectangle(candlebrush2, 419, 215, 10, 40);
            g.FillRectangle(candlebrush4, 436, 240, 10, 40);
            g.FillRectangle(candlebrush1, 457, 235, 10, 40);
            g.FillRectangle(candlebrush4, 481, 225, 10, 40);
            g.FillRectangle(candlebrush2, 500, 234, 10, 40);
            g.FillRectangle(candlebrush3, 516, 220, 10, 40);

            //Bubbles
            g.FillEllipse(bubblebrush, 137, 300, 40, 40);
            g.FillEllipse(bubblebrush, 80, 260, 40, 40);
            g.FillEllipse(bubblebrush, 163, 250, 40, 40);
            g.FillEllipse(bubblebrush, 142, 135, 40, 40);
            g.FillEllipse(bubblebrush, 90, 200, 40, 40);
            g.FillEllipse(bubblebrush, 173, 190, 40, 40);
            g.FillEllipse(bubblebrush, 622, 305, 40, 40);
            g.FillEllipse(bubblebrush, 576, 265, 40, 40);
            g.FillEllipse(bubblebrush, 668, 255, 40, 40);
            g.FillEllipse(bubblebrush, 638, 130, 40, 40);
            g.FillEllipse(bubblebrush, 590, 205, 40, 40);
            g.FillEllipse(bubblebrush, 657, 195, 40, 40);
            g.FillEllipse(bubblebrush, 680, 320, 40, 40);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //graphics
            Graphics g = this.CreateGraphics();

            //text graphics
            Font eatfont = new Font("Papyrus", 25, FontStyle.Bold);
            Font birthdayfont = new Font("Monotype Corsiva", 45, FontStyle.Italic);
            SolidBrush birthdayfontbrush = new SolidBrush(Color.DarkRed);
            SolidBrush eatfontbrush = new SolidBrush(Color.Blue);

            //cake body
            SolidBrush cakebrush = new SolidBrush(Color.Chocolate);
            SolidBrush cakebrush2 = new SolidBrush(Color.DarkSlateBlue);

            //candle brushes
            SolidBrush candlebrush1 = new SolidBrush(Color.OrangeRed);
            SolidBrush candlebrush2 = new SolidBrush(Color.LawnGreen);
            SolidBrush candlebrush3 = new SolidBrush(Color.DodgerBlue);
            SolidBrush candlebrush4 = new SolidBrush(Color.Gold);
            SolidBrush candleflame = new SolidBrush(Color.Orange);

            //freckle and bubble brushes
            SolidBrush frecklebrush = new SolidBrush(Color.WhiteSmoke);
            SolidBrush bubblebrush = new SolidBrush(Color.LightBlue);

            //sounds
            SoundPlayer birth = new SoundPlayer(Properties.Resources.HappyBirthday);
            SoundPlayer munch = new SoundPlayer(Properties.Resources.munch);

            //Clear screen
            g.Clear(Color.Khaki);
            g.DrawString("HAPPY BIRTHDAY", birthdayfont, birthdayfontbrush, 150, 40);
       
            //cake with candles blown out
            g.FillRectangle(cakebrush, 280, 280, 260, 110);
            g.FillRectangle(cakebrush2, 280, 230, 260, 80);

            //Frosting edges
            g.FillEllipse(cakebrush2, 280, 295, 20, 20);
            g.FillEllipse(cakebrush2, 300, 295, 20, 20);
            g.FillEllipse(cakebrush2, 320, 295, 20, 20);
            g.FillEllipse(cakebrush2, 340, 295, 20, 20);
            g.FillEllipse(cakebrush2, 360, 295, 20, 20);
            g.FillEllipse(cakebrush2, 380, 295, 20, 20);
            g.FillEllipse(cakebrush2, 400, 295, 20, 20);
            g.FillEllipse(cakebrush2, 420, 295, 20, 20);
            g.FillEllipse(cakebrush2, 440, 295, 20, 20);
            g.FillEllipse(cakebrush2, 460, 295, 20, 20);
            g.FillEllipse(cakebrush2, 480, 295, 20, 20);
            g.FillEllipse(cakebrush2, 500, 295, 20, 20);
            g.FillEllipse(cakebrush2, 520, 295, 20, 20);

            //Frosting Freckles
            g.FillEllipse(frecklebrush, 285, 260, 5, 5);
            g.FillEllipse(frecklebrush, 297, 290, 5, 5);
            g.FillEllipse(frecklebrush, 306, 270, 5, 5);
            g.FillEllipse(frecklebrush, 312, 300, 5, 5);
            g.FillEllipse(frecklebrush, 313, 252, 5, 5);
            g.FillEllipse(frecklebrush, 331, 275, 5, 5);
            g.FillEllipse(frecklebrush, 340, 260, 5, 5);
            g.FillEllipse(frecklebrush, 352, 290, 5, 5);
            g.FillEllipse(frecklebrush, 361, 270, 5, 5);
            g.FillEllipse(frecklebrush, 367, 300, 5, 5);
            g.FillEllipse(frecklebrush, 368, 252, 5, 5);
            g.FillEllipse(frecklebrush, 386, 275, 5, 5);
            g.FillEllipse(frecklebrush, 395, 260, 5, 5);
            g.FillEllipse(frecklebrush, 416, 270, 5, 5);
            g.FillEllipse(frecklebrush, 422, 300, 5, 5);
            g.FillEllipse(frecklebrush, 423, 252, 5, 5);
            g.FillEllipse(frecklebrush, 441, 275, 5, 5);
            g.FillEllipse(frecklebrush, 450, 260, 5, 5);
            g.FillEllipse(frecklebrush, 462, 290, 5, 5);
            g.FillEllipse(frecklebrush, 471, 270, 5, 5);
            g.FillEllipse(frecklebrush, 477, 300, 5, 5);
            g.FillEllipse(frecklebrush, 478, 252, 5, 5);
            g.FillEllipse(frecklebrush, 496, 275, 5, 5);
            g.FillEllipse(frecklebrush, 505, 260, 5, 5);
            g.FillEllipse(frecklebrush, 517, 290, 5, 5);
            g.FillEllipse(frecklebrush, 526, 270, 5, 5);
            g.FillEllipse(frecklebrush, 532, 300, 5, 5);

            //candles
            g.FillRectangle(candlebrush1, 291, 222, 10, 40);
            g.FillRectangle(candlebrush2, 320, 245, 10, 40);
            g.FillRectangle(candlebrush3, 340, 228, 10, 40);
            g.FillRectangle(candlebrush1, 364, 219, 10, 40);
            g.FillRectangle(candlebrush4, 380, 237, 10, 40);
            g.FillRectangle(candlebrush3, 400, 226, 10, 40);
            g.FillRectangle(candlebrush2, 419, 215, 10, 40);
            g.FillRectangle(candlebrush4, 436, 240, 10, 40);
            g.FillRectangle(candlebrush1, 457, 235, 10, 40);
            g.FillRectangle(candlebrush4, 481, 225, 10, 40);
            g.FillRectangle(candlebrush2, 500, 234, 10, 40);
            g.FillRectangle(candlebrush3, 516, 220, 10, 40);

            //Bubbles
            g.FillEllipse(bubblebrush, 137, 300, 40, 40);
            g.FillEllipse(bubblebrush, 80, 260, 40, 40);
            g.FillEllipse(bubblebrush, 163, 250, 40, 40);
            g.FillEllipse(bubblebrush, 142, 135, 40, 40);
            g.FillEllipse(bubblebrush, 90, 200, 40, 40);
            g.FillEllipse(bubblebrush, 173, 190, 40, 40);
            g.FillEllipse(bubblebrush, 622, 305, 40, 40);
            g.FillEllipse(bubblebrush, 576, 265, 40, 40);
            g.FillEllipse(bubblebrush, 668, 255, 40, 40);
            g.FillEllipse(bubblebrush, 638, 130, 40, 40);
            g.FillEllipse(bubblebrush, 590, 205, 40, 40);
            g.FillEllipse(bubblebrush, 657, 195, 40, 40);
            g.FillEllipse(bubblebrush, 680, 320, 40, 40);

            Thread.Sleep(1000);

            //cake without candles

            //text and clear
            g.DrawString("HAPPY BIRTHDAY", birthdayfont, birthdayfontbrush, 150, 40);
            g.Clear(Color.Khaki);

            //cake body
            g.FillRectangle(cakebrush, 280, 280, 260, 110);
            g.FillRectangle(cakebrush2, 280, 230, 260, 80);

            //Frosting edges
            g.FillEllipse(cakebrush2, 280, 295, 20, 20);
            g.FillEllipse(cakebrush2, 300, 295, 20, 20);
            g.FillEllipse(cakebrush2, 320, 295, 20, 20);
            g.FillEllipse(cakebrush2, 340, 295, 20, 20);
            g.FillEllipse(cakebrush2, 360, 295, 20, 20);
            g.FillEllipse(cakebrush2, 380, 295, 20, 20);
            g.FillEllipse(cakebrush2, 400, 295, 20, 20);
            g.FillEllipse(cakebrush2, 420, 295, 20, 20);
            g.FillEllipse(cakebrush2, 440, 295, 20, 20);
            g.FillEllipse(cakebrush2, 460, 295, 20, 20);
            g.FillEllipse(cakebrush2, 480, 295, 20, 20);
            g.FillEllipse(cakebrush2, 500, 295, 20, 20);
            g.FillEllipse(cakebrush2, 520, 295, 20, 20);

            //Frosting Freckles
            g.FillEllipse(frecklebrush, 285, 260, 5, 5);
            g.FillEllipse(frecklebrush, 297, 290, 5, 5);
            g.FillEllipse(frecklebrush, 306, 270, 5, 5);
            g.FillEllipse(frecklebrush, 312, 300, 5, 5);
            g.FillEllipse(frecklebrush, 313, 252, 5, 5);
            g.FillEllipse(frecklebrush, 331, 275, 5, 5);
            g.FillEllipse(frecklebrush, 340, 260, 5, 5);
            g.FillEllipse(frecklebrush, 352, 290, 5, 5);
            g.FillEllipse(frecklebrush, 361, 270, 5, 5);
            g.FillEllipse(frecklebrush, 367, 300, 5, 5);
            g.FillEllipse(frecklebrush, 368, 252, 5, 5);
            g.FillEllipse(frecklebrush, 386, 275, 5, 5);
            g.FillEllipse(frecklebrush, 395, 260, 5, 5);
            g.FillEllipse(frecklebrush, 416, 270, 5, 5);
            g.FillEllipse(frecklebrush, 422, 300, 5, 5);
            g.FillEllipse(frecklebrush, 423, 252, 5, 5);
            g.FillEllipse(frecklebrush, 441, 275, 5, 5);
            g.FillEllipse(frecklebrush, 450, 260, 5, 5);
            g.FillEllipse(frecklebrush, 462, 290, 5, 5);
            g.FillEllipse(frecklebrush, 471, 270, 5, 5);
            g.FillEllipse(frecklebrush, 477, 300, 5, 5);
            g.FillEllipse(frecklebrush, 478, 252, 5, 5);
            g.FillEllipse(frecklebrush, 496, 275, 5, 5);
            g.FillEllipse(frecklebrush, 505, 260, 5, 5);
            g.FillEllipse(frecklebrush, 517, 290, 5, 5);
            g.FillEllipse(frecklebrush, 526, 270, 5, 5);
            g.FillEllipse(frecklebrush, 532, 300, 5, 5);

            //Bubbles
            g.FillEllipse(bubblebrush, 137, 300, 40, 40);
            g.FillEllipse(bubblebrush, 80, 260, 40, 40);
            g.FillEllipse(bubblebrush, 163, 250, 40, 40);
            g.FillEllipse(bubblebrush, 142, 135, 40, 40);
            g.FillEllipse(bubblebrush, 90, 200, 40, 40);
            g.FillEllipse(bubblebrush, 173, 190, 40, 40);
            g.FillEllipse(bubblebrush, 622, 305, 40, 40);
            g.FillEllipse(bubblebrush, 576, 265, 40, 40);
            g.FillEllipse(bubblebrush, 668, 255, 40, 40);
            g.FillEllipse(bubblebrush, 638, 130, 40, 40);
            g.FillEllipse(bubblebrush, 590, 205, 40, 40);
            g.FillEllipse(bubblebrush, 657, 195, 40, 40);
            g.FillEllipse(bubblebrush, 680, 320, 40, 40);

            //happy birthday text
            g.DrawString("HAPPY BIRTHDAY", birthdayfont, birthdayfontbrush, 150, 40);

            //Sound
            Thread.Sleep(200);
            birth.Play();
            Thread.Sleep(1000);
            
            //message text
            g.DrawString("Hope you have fun today!", eatfont, eatfontbrush, 195, 100);
            Thread.Sleep(1000);

            g.Clear(Color.Khaki);

            g.DrawString("HAPPY BIRTHDAY", birthdayfont, birthdayfontbrush, 150, 40);
            g.DrawString("Hope you have fun today!", eatfont, eatfontbrush, 195, 100);

            //Cake animation frame 2
            g.Clear(Color.Khaki);
            munch.Play();
            g.DrawString("HAPPY BIRTHDAY", birthdayfont, birthdayfontbrush, 150, 40);
            g.DrawString("Hope you have fun today!", eatfont, eatfontbrush, 195, 100);

            //cake body
            g.FillRectangle(cakebrush, 340, 280, 200, 110);
            g.FillRectangle(cakebrush2, 340, 230, 200, 80);

            //Frosting edges
            g.FillEllipse(cakebrush2, 340, 295, 20, 20);
            g.FillEllipse(cakebrush2, 360, 295, 20, 20);
            g.FillEllipse(cakebrush2, 380, 295, 20, 20);
            g.FillEllipse(cakebrush2, 400, 295, 20, 20);
            g.FillEllipse(cakebrush2, 420, 295, 20, 20);
            g.FillEllipse(cakebrush2, 440, 295, 20, 20);
            g.FillEllipse(cakebrush2, 460, 295, 20, 20);
            g.FillEllipse(cakebrush2, 480, 295, 20, 20);
            g.FillEllipse(cakebrush2, 500, 295, 20, 20);
            g.FillEllipse(cakebrush2, 520, 295, 20, 20);

            //Frosting Freckles
            g.FillEllipse(frecklebrush, 340, 260, 5, 5);
            g.FillEllipse(frecklebrush, 352, 290, 5, 5);
            g.FillEllipse(frecklebrush, 361, 270, 5, 5);
            g.FillEllipse(frecklebrush, 367, 300, 5, 5);
            g.FillEllipse(frecklebrush, 368, 252, 5, 5);
            g.FillEllipse(frecklebrush, 386, 275, 5, 5);
            g.FillEllipse(frecklebrush, 395, 260, 5, 5);
            g.FillEllipse(frecklebrush, 416, 270, 5, 5);
            g.FillEllipse(frecklebrush, 422, 300, 5, 5);
            g.FillEllipse(frecklebrush, 423, 252, 5, 5);
            g.FillEllipse(frecklebrush, 441, 275, 5, 5);
            g.FillEllipse(frecklebrush, 450, 260, 5, 5);
            g.FillEllipse(frecklebrush, 462, 290, 5, 5);
            g.FillEllipse(frecklebrush, 471, 270, 5, 5);
            g.FillEllipse(frecklebrush, 477, 300, 5, 5);
            g.FillEllipse(frecklebrush, 478, 252, 5, 5);
            g.FillEllipse(frecklebrush, 496, 275, 5, 5);
            g.FillEllipse(frecklebrush, 505, 260, 5, 5);
            g.FillEllipse(frecklebrush, 517, 290, 5, 5);
            g.FillEllipse(frecklebrush, 526, 270, 5, 5);
            g.FillEllipse(frecklebrush, 532, 300, 5, 5);

            //Bubbles
            g.FillEllipse(bubblebrush, 137, 300, 40, 40);
            g.FillEllipse(bubblebrush, 80, 260, 40, 40);
            g.FillEllipse(bubblebrush, 163, 250, 40, 40);
            g.FillEllipse(bubblebrush, 142, 135, 40, 40);
            g.FillEllipse(bubblebrush, 90, 200, 40, 40);
            g.FillEllipse(bubblebrush, 173, 190, 40, 40);
            g.FillEllipse(bubblebrush, 622, 305, 40, 40);
            g.FillEllipse(bubblebrush, 576, 265, 40, 40);
            g.FillEllipse(bubblebrush, 668, 255, 40, 40);
            g.FillEllipse(bubblebrush, 638, 130, 40, 40);
            g.FillEllipse(bubblebrush, 590, 205, 40, 40);
            g.FillEllipse(bubblebrush, 657, 195, 40, 40);
            g.FillEllipse(bubblebrush, 680, 320, 40, 40);

            Thread.Sleep(2000);

            //Cake animation frame 3

            //text, clear, and sound
            g.Clear(Color.Khaki);
            munch.Play();
            g.DrawString("HAPPY BIRTHDAY", birthdayfont, birthdayfontbrush, 150, 40);
            g.DrawString("Hope you have fun today!", eatfont, eatfontbrush, 195, 100);

            //cake
            g.FillRectangle(cakebrush, 380, 280, 160, 110);
            g.FillRectangle(cakebrush2, 380, 230, 160, 80);

            //Frosting edges
            g.FillEllipse(cakebrush2, 380, 295, 20, 20);
            g.FillEllipse(cakebrush2, 400, 295, 20, 20);
            g.FillEllipse(cakebrush2, 420, 295, 20, 20);
            g.FillEllipse(cakebrush2, 440, 295, 20, 20);
            g.FillEllipse(cakebrush2, 460, 295, 20, 20);
            g.FillEllipse(cakebrush2, 480, 295, 20, 20);
            g.FillEllipse(cakebrush2, 500, 295, 20, 20);
            g.FillEllipse(cakebrush2, 520, 295, 20, 20);

            //Frosting Freckles
            g.FillEllipse(frecklebrush, 386, 275, 5, 5);
            g.FillEllipse(frecklebrush, 515, 300, 5, 5);
            g.FillEllipse(frecklebrush, 395, 260, 5, 5);
            g.FillEllipse(frecklebrush, 416, 270, 5, 5);
            g.FillEllipse(frecklebrush, 422, 300, 5, 5);
            g.FillEllipse(frecklebrush, 423, 252, 5, 5);
            g.FillEllipse(frecklebrush, 441, 275, 5, 5);
            g.FillEllipse(frecklebrush, 450, 260, 5, 5);
            g.FillEllipse(frecklebrush, 462, 290, 5, 5);
            g.FillEllipse(frecklebrush, 471, 270, 5, 5);
            g.FillEllipse(frecklebrush, 477, 300, 5, 5);
            g.FillEllipse(frecklebrush, 478, 252, 5, 5);
            g.FillEllipse(frecklebrush, 496, 275, 5, 5);
            g.FillEllipse(frecklebrush, 505, 260, 5, 5);
            g.FillEllipse(frecklebrush, 517, 290, 5, 5);
            g.FillEllipse(frecklebrush, 526, 270, 5, 5);
            g.FillEllipse(frecklebrush, 532, 300, 5, 5);

            //Bubbles
            g.FillEllipse(bubblebrush, 137, 300, 40, 40);
            g.FillEllipse(bubblebrush, 80, 260, 40, 40);
            g.FillEllipse(bubblebrush, 163, 250, 40, 40);
            g.FillEllipse(bubblebrush, 142, 135, 40, 40);
            g.FillEllipse(bubblebrush, 90, 200, 40, 40);
            g.FillEllipse(bubblebrush, 173, 190, 40, 40);
            g.FillEllipse(bubblebrush, 622, 305, 40, 40);
            g.FillEllipse(bubblebrush, 576, 265, 40, 40);
            g.FillEllipse(bubblebrush, 668, 255, 40, 40);
            g.FillEllipse(bubblebrush, 638, 130, 40, 40);
            g.FillEllipse(bubblebrush, 590, 205, 40, 40);
            g.FillEllipse(bubblebrush, 657, 195, 40, 40);
            g.FillEllipse(bubblebrush, 680, 320, 40, 40);

            Thread.Sleep(2000);

            //Cake animation frame 4

            //text, clear, and sound
            g.Clear(Color.Khaki);
            munch.Play();
            g.DrawString("HAPPY BIRTHDAY", birthdayfont, birthdayfontbrush, 150, 40);
            g.DrawString("Hope you have fun today!", eatfont, eatfontbrush, 195, 100);

            //cake
            g.FillRectangle(cakebrush, 420, 280, 120, 110);
            g.FillRectangle(cakebrush2, 420, 230, 120, 80);

            //Frosting edges
            g.FillEllipse(cakebrush2, 420, 295, 20, 20);
            g.FillEllipse(cakebrush2, 440, 295, 20, 20);
            g.FillEllipse(cakebrush2, 460, 295, 20, 20);
            g.FillEllipse(cakebrush2, 480, 295, 20, 20);
            g.FillEllipse(cakebrush2, 500, 295, 20, 20);
            g.FillEllipse(cakebrush2, 520, 295, 20, 20);

            //Frosting Freckles
            g.FillEllipse(frecklebrush, 422, 300, 5, 5);
            g.FillEllipse(frecklebrush, 423, 252, 5, 5);
            g.FillEllipse(frecklebrush, 441, 275, 5, 5);
            g.FillEllipse(frecklebrush, 450, 260, 5, 5);
            g.FillEllipse(frecklebrush, 462, 290, 5, 5);
            g.FillEllipse(frecklebrush, 471, 270, 5, 5);
            g.FillEllipse(frecklebrush, 477, 300, 5, 5);
            g.FillEllipse(frecklebrush, 478, 252, 5, 5);
            g.FillEllipse(frecklebrush, 496, 275, 5, 5);
            g.FillEllipse(frecklebrush, 505, 260, 5, 5);
            g.FillEllipse(frecklebrush, 517, 290, 5, 5);
            g.FillEllipse(frecklebrush, 526, 270, 5, 5);
            g.FillEllipse(frecklebrush, 532, 300, 5, 5);

            //Bubbles
            g.FillEllipse(bubblebrush, 137, 300, 40, 40);
            g.FillEllipse(bubblebrush, 80, 260, 40, 40);
            g.FillEllipse(bubblebrush, 163, 250, 40, 40);
            g.FillEllipse(bubblebrush, 142, 135, 40, 40);
            g.FillEllipse(bubblebrush, 90, 200, 40, 40);
            g.FillEllipse(bubblebrush, 173, 190, 40, 40);
            g.FillEllipse(bubblebrush, 622, 305, 40, 40);
            g.FillEllipse(bubblebrush, 576, 265, 40, 40);
            g.FillEllipse(bubblebrush, 668, 255, 40, 40);
            g.FillEllipse(bubblebrush, 638, 130, 40, 40);
            g.FillEllipse(bubblebrush, 590, 205, 40, 40);
            g.FillEllipse(bubblebrush, 657, 195, 40, 40);
            g.FillEllipse(bubblebrush, 680, 320, 40, 40);

            Thread.Sleep(2000);

            //Cake animation frame 5

            //text, clear, and sound
            g.Clear(Color.Khaki);
            munch.Play();
            g.DrawString("HAPPY BIRTHDAY", birthdayfont, birthdayfontbrush, 150, 40);
            g.DrawString("Hope you have fun today!", eatfont, eatfontbrush, 195, 100);

            //cake
            g.FillRectangle(cakebrush, 480, 280, 60, 110);
            g.FillRectangle(cakebrush2, 480, 230, 60, 80);

            //Frosting edges
            g.FillEllipse(cakebrush2, 480, 295, 20, 20);
            g.FillEllipse(cakebrush2, 500, 295, 20, 20);
            g.FillEllipse(cakebrush2, 520, 295, 20, 20);

            //Frosting Freckles
            g.FillEllipse(frecklebrush, 496, 275, 5, 5);
            g.FillEllipse(frecklebrush, 505, 260, 5, 5);
            g.FillEllipse(frecklebrush, 517, 290, 5, 5);
            g.FillEllipse(frecklebrush, 526, 270, 5, 5);
            g.FillEllipse(frecklebrush, 532, 300, 5, 5);

            //Bubbles
            g.FillEllipse(bubblebrush, 137, 300, 40, 40);
            g.FillEllipse(bubblebrush, 80, 260, 40, 40);
            g.FillEllipse(bubblebrush, 163, 250, 40, 40);
            g.FillEllipse(bubblebrush, 142, 135, 40, 40);
            g.FillEllipse(bubblebrush, 90, 200, 40, 40);
            g.FillEllipse(bubblebrush, 173, 190, 40, 40);
            g.FillEllipse(bubblebrush, 622, 305, 40, 40);
            g.FillEllipse(bubblebrush, 576, 265, 40, 40);
            g.FillEllipse(bubblebrush, 668, 255, 40, 40);
            g.FillEllipse(bubblebrush, 638, 130, 40, 40);
            g.FillEllipse(bubblebrush, 590, 205, 40, 40);
            g.FillEllipse(bubblebrush, 657, 195, 40, 40);
            g.FillEllipse(bubblebrush, 680, 320, 40, 40);

            Thread.Sleep(2000);

            //Cake animation frame 6

            //text, clear, and sound
            g.Clear(Color.Khaki);
            munch.Play();
            g.DrawString("HAPPY BIRTHDAY", birthdayfont, birthdayfontbrush, 150, 40);
            g.DrawString("Hope you have fun today!", eatfont, eatfontbrush, 195, 100);

            //Bubbles
            g.FillEllipse(bubblebrush, 137, 300, 40, 40);
            g.FillEllipse(bubblebrush, 80, 260, 40, 40);
            g.FillEllipse(bubblebrush, 163, 250, 40, 40);
            g.FillEllipse(bubblebrush, 142, 135, 40, 40);
            g.FillEllipse(bubblebrush, 90, 200, 40, 40);
            g.FillEllipse(bubblebrush, 173, 190, 40, 40);
            g.FillEllipse(bubblebrush, 622, 305, 40, 40);
            g.FillEllipse(bubblebrush, 576, 265, 40, 40);
            g.FillEllipse(bubblebrush, 668, 255, 40, 40);
            g.FillEllipse(bubblebrush, 638, 130, 40, 40);
            g.FillEllipse(bubblebrush, 590, 205, 40, 40);
            g.FillEllipse(bubblebrush, 657, 195, 40, 40);
            g.FillEllipse(bubblebrush, 680, 320, 40, 40);

            Thread.Sleep(2000);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //graphics objects
            Graphics g = this.CreateGraphics();

            Font bye = new Font("Papyrus", 40, FontStyle.Bold);
            SolidBrush byebrush = new SolidBrush(Color.Blue);
           
            //goodbye message
            Thread.Sleep(600);
            g.Clear(Color.Khaki);
            g.DrawString("Have a great birthday!!!", bye, byebrush, 125, 60);
            Thread.Sleep(1000);
        }
    }
}
