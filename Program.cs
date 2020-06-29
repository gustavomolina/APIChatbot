using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;

namespace APIChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://web.whatsapp.com";
            List<string> contatos = new List<string>()
            {
                "Teste Bot Whatsapp"
            };

            //Instancia do ChromeDriver
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            //Espera um tempo para escanear o QR Code do WhatsApp
            Thread.Sleep(7000);

            //Abre as conversas
            //Manda mensagem para todos os contatos
            foreach (var contato in contatos)
            {
                //Quando estamos na tela de pesquisa
                //<div class="_3FRCZ copyable-text selectable-text" contenteditable="true" data-tab="3" dir="ltr"></div>
                var pesquisaEl = driver.FindElementByClassName("_3FRCZ");
                //if (contato.ToString() == "Mãe"){
                    pesquisaEl.SendKeys(contato);
                //}

                //Tempo entre a digitação e a pesquisa
                Thread.Sleep(10000);
                //<span dir="auto" title="Teste Bot Whatsapp" class="_3ko75 _5h6Y_ _3Whw5">Teste Bot Whatsapp</span>
                //<div class="_3CneP"><span class="_357i8"><span dir="auto" title="Mãe" class="_3ko75 _5h6Y_ _3Whw5"><span class="matched-text _3Whw5">Mãe</span></span><div class="_3XFan"></div></span></div>

                var contatoElemento = driver.FindElementByXPath("//span[@title='Teste Bot Whatsapp']");
                
                //Clicka no contato:
                contatoElemento.Click();
                //Thread.Sleep(3000);

                //Clicka na caixa de entrada de texto
                //<div tabindex="-1" class="_3uMse"><div tabindex="-1" class="_2FVVk _2UL8j"><div class="_2FbwG" style="visibility: visible;">Digite uma mensagem</div><div class="_3FRCZ copyable-text selectable-text" contenteditable="true" data-tab="1" dir="ltr" spellcheck="true"></div></div></div>
                var chatElemento = driver.FindElementByClassName("_3uMse");
                chatElemento.Click();

                Thread.Sleep(3000);
                //Digita o texto
                chatElemento.SendKeys("Olá, eu sou um robô!");

                //Envia o texto
                //<div class="_1JNuk"><button class="_1U1xa"><span data-icon="send" class=""><svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" width="24" height="24"><path fill="currentColor" d="M1.101 21.757L23.8 12.028 1.101 2.3l.011 7.912 13.623 1.816-13.623 1.817-.011 7.912z"></path></svg></span></button></div>
                // var enviaElemento = driver.FindElementByClassName("_1JNuk");
                // enviaElemento.Click();

                //<span data-icon="send" class=""><svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" width="24" height="24"><path fill="currentColor" d="M1.101 21.757L23.8 12.028 1.101 2.3l.011 7.912 13.623 1.816-13.623 1.817-.011 7.912z"></path></svg></span>
                var buttonSend = driver.FindElementByXPath($"//span[@data-icon='send']");
                buttonSend.Click();
            }

        }
    }
}
