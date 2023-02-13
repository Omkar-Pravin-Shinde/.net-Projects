using System;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TextToSpeechConverter
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices clist = new Choices();
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer speechSynthesizerObj;
        private void Form1_Load(object sender, EventArgs e)
        {
            speechSynthesizerObj = new SpeechSynthesizer();
            btn_Resume.Enabled = false;
            btn_Pause.Enabled = false;
            btn_Stop.Enabled = false;
        }
        

        private void btn_Speak_Click(object sender, EventArgs e)
        {
            //Stop the SpeechSynthesizer object 
            speechSynthesizerObj.Dispose();
            if(richTextBox1.Text!="")
            {
                speechSynthesizerObj = new SpeechSynthesizer();
                //Asynchronously speaks the contents present in RichTextBox1
                speechSynthesizerObj.SpeakAsync(richTextBox1.Text);
                btn_Pause.Enabled = true;
                btn_Stop.Enabled = true;
            }
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            if(speechSynthesizerObj!=null)
            {
                //Gets the current speaking state of the SpeechSynthesizer object.
                if(speechSynthesizerObj.State==SynthesizerState.Speaking)
                {
                    //Pauses the SpeechSynthesizer object.
                    speechSynthesizerObj.Pause();
                    btn_Resume.Enabled = true;
                    btn_Speak.Enabled = false;
                }
            }
        }

        private void btn_Resume_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                if (speechSynthesizerObj.State == SynthesizerState.Paused)
                {
                    //Resumes the SpeechSynthesizer object after it has been paused.
                    speechSynthesizerObj.Resume();
                    btn_Resume.Enabled = false;
                    btn_Speak.Enabled = true;
                }
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if(speechSynthesizerObj!=null)
            {
                //Disposes the SpeechSynthesizer object 
                speechSynthesizerObj.Dispose();
                btn_Speak.Enabled = true;
                btn_Resume.Enabled = false;
                btn_Pause.Enabled = false;
                btn_Stop.Enabled = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
            //Grammar words = new DictationGrammar();
            //sr.LoadGrammar(words);
            //try
            //{
            //    richTextBox2.Text = "Listening Now...";
            //    sr.SetInputToDefaultAudioDevice();
            //    RecognitionResult result = sr.Recognize();
            //    richTextBox2.Clear();
            //    richTextBox2.Text = result.Text;
            //}
            //catch
            //{
            //    richTextBox2.Text = "";
            //    MessageBox.Show("Mic notfound");

            //}
            //finally
            //{
            //    sr.UnloadAllGrammars();
            //}
            button1.Enabled = false;
            button2.Enabled = true;
            clist.Add(new string[] { "Hi", "Hello", "Good morning" });
            Grammar gr = new Grammar(new GrammarBuilder(clist));
            // Grammar gr = new DictationGrammar();
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_SpeechRecognized;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
            


        }

        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            richTextBox2.Text = richTextBox2.Text + e.Result.Text.ToString() + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sre.RecognizeAsyncStop();
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
