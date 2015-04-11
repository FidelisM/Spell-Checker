using SharpEcho.Recruiting.SpellChecker.Contracts;
using System.Net;
using System;

namespace SharpEcho.Recruiting.SpellChecker.Core
{
    /// <summary>
    /// This is a dictionary based spell checker that uses dictionary.com to determine if
    /// a word is spelled correctly
    /// 
    /// The URL to do this looks like this: http://dictionary.reference.com/browse/<word>
    /// where <word> is the word to be checked
    /// 
    /// Example: http://dictionary.reference.com/browse/SharpEcho would lookup the word SharpEcho
    /// 
    /// We look for something in the response that gives us a clear indication whether the
    /// word is spelled correctly or not
    /// </summary>
    public class DictionaryDotComSpellChecker : ISpellChecker
    {
        public bool Check(string word)
        {
            string url = "http://dictionary.reference.com/browse/" + word;
            HttpWebResponse response;
            HttpWebRequest request;
                        
            Uri urlCheck = new Uri(url);
            request = (HttpWebRequest)WebRequest.Create(urlCheck);
            request.AllowAutoRedirect = false;
            request.Timeout = 15000;

            try
            {
                // Request page from server
                response = (HttpWebResponse)request.GetResponse();
                
                // If the page exists (Status code - 200) the word exists
                // and is spelled correctly
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }

                // Else if there is a reditect to another page or page does not exist
                // then word is spelled incorrectly
                else
                {
                    return false;
                }
                
                //throw new System.NotImplementedException();
            }
            
            catch (Exception)
            {
                // Request to server may time out and throw an exception

                Console.WriteLine("Request timeout on word:- " + word);
                return true;
            }            
          
        }
    }
}
