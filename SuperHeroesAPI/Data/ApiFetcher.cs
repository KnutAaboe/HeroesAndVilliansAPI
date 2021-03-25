using Newtonsoft.Json;
using SuperHeroesAPI.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SuperHeroesAPI.Data
{

    public class ApiFetcher : IApiFetcher
    {

        private readonly string apiKey = "4119716678052887";
        //private readonly string apiKey = API.APIKEY;

        public IEnumerable<SuperHero> GetSuperHeroes()
        {
            var soups = Fetcher.getSuperHeroes(apiKey);
            return soups;
            
        }

        public SuperHero GetSuperHero(string id)
        {
            SuperHero soup = Fetcher.getSuperHeroById(id, apiKey);
            return soup;

        }
    }

    public static class Fetcher
    {
        public static async SuperHero getSuperHeroById(string id, string api_key)
        {
            string url = string.Format("https://www.superheroapi.com/api.php/" + api_key + "/" + id + "/powerstats"); //4119716678052887/287/biography
            WebRequest reqObj = WebRequest.Create(url);
            reqObj.Method = "GET";

            try
            {

                HttpWebResponse resObj = (HttpWebResponse)reqObj.GetResponse();

                string result = "";
                using (Stream stream = resObj.GetResponseStream())
                {
                    StreamReader streamR = new StreamReader(stream);
                    result = streamR.ReadToEnd();
                    streamR.Close();


                }
                System.Diagnostics.Debug.WriteLine(result);

                SuperHero suop = JsonConvert.DeserializeObject<SuperHero>(result);
                return suop;

            } catch (WebException e)
            {
                System.Console.WriteLine(e.Message);
                return new SuperHero { };
            }
            
        }

        public static async IEnumerable<SuperHero> getSuperHeroes(string api_key)
        {
            bool isObject = true;
            do
            {
                if (1 == 1)
                {




                }
            } while (isObject);

            string url = string.Format("https://www.superheroapi.com/api.php/" + api_key + "/" + id + "/powerstats"); //4119716678052887/287/biography
            WebRequest reqObj = WebRequest.Create(url);
            reqObj.Method = "GET";

            try
            {

                HttpWebResponse resObj = (HttpWebResponse)reqObj.GetResponse();

                string result = "";
                using (Stream stream = resObj.GetResponseStream())
                {
                    StreamReader streamR = new StreamReader(stream);
                    result = streamR.ReadToEnd();
                    streamR.Close();


                }
                System.Diagnostics.Debug.WriteLine(result);

            }
            catch (WebException e)
            {
                System.Console.WriteLine(e.Message);
            }

        }

    }

}

