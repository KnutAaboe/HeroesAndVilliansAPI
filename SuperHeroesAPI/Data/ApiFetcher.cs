using HeroesAndVilliansAPI.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SuperHeroesAPI.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SuperHeroesAPI.Data
{

    public class ApiFetcher : IApiFetcher
    {
        //Need your own apiKey
        private readonly string apiKey = "";

        public AllinfoHV.Root GetHeroVillianInfoByID(string id)
        {
            string baseURL = "https://superheroapi.com/api/";
            string endURL = "/" + id;
            string method = "GET";
            JObject parsedObject = GetJsonData(baseURL, endURL, method);

            string jsonData = parsedObject.ToString();
            AllinfoHV.Root allInfoSH = JsonConvert.DeserializeObject<AllinfoHV.Root>(jsonData);

            if (allInfoSH.response == "success")
            {
                return allInfoSH;
            } else
            {
                return null;
            }
        }

         public List<string> GetAllHeroesVillians(int startID, string alignment)
        {

            string baseURL = "https://superheroapi.com/api/";
            string method = "GET";
            List<string> superHeroes = new();
            bool more = true;
            int id = startID;
            int max = 100;

            do //works without the max thing
            {
                string endURL = "/" + id;
                JObject parsedObject = GetJsonData(baseURL, endURL, method);
                string jsonData = parsedObject.ToString();
                string addToList;
                string spacing = "";
                if (id <= 9) { spacing = "   "; }
                else if (id <= 99) { spacing = "  "; }
                else if (id > 99) { spacing = " "; }


                Names.Rooot superbio = JsonConvert.DeserializeObject<Names.Rooot>(jsonData);
                if (superbio.biography != null)
                {
                    if (alignment == "good" || alignment == "bad") { 


                    if (superbio.biography.alignment.Equals(alignment))
                    {
                        switch (!(superbio.biography.FullName.Equals("")))
                        {
                            case true:
                                addToList = id.ToString() + spacing + "img: " + superbio.image.url + " | " + superbio.biography.FullName + ", aka " + superbio.name;
                                break;

                            default:
                                addToList = id.ToString() + spacing + "| img: " + superbio.image.url + " | " + superbio.name;
                                break;
                        }

                        superHeroes.Add(addToList);

                    }

                    
                } else if (alignment == null)
                    {
                        
                            switch (!(superbio.biography.FullName.Equals("")))
                            {
                                case true:
                                    addToList = id.ToString() + spacing + "| img: " + superbio.image.url + " | " + superbio.biography.FullName + ", aka " + superbio.name;
                                    break;

                                default:
                                    addToList = id.ToString() + spacing + "| img: " + superbio.image.url + " | " + superbio.name;
                                    break;
                            }

                            superHeroes.Add(addToList);


                    }
                    id++;
                    more = true;

                }
                else
                {
                    more = false;
                    break;
                }
            } while (more == true && !(id - startID == max)); //&& !(id - startID == max)

            if (superHeroes.Count < 1)
            {
                return null;
            } else
            {
                return superHeroes;
            }


        }

        public Search.Data SearchForHeroesVillians(string letters, string where)
        {

            if (!(letters.Equals("")))
            {
                string baseURL = "https://superheroapi.com/api/";
                string method = "GET";
                List<string> superHeroes = new();

                string endURL = "/search/" + letters;
                JObject parsedObject = GetJsonData(baseURL, endURL, method);
                string jsonData = parsedObject.ToString();

                Search.Data heroesVillians = JsonConvert.DeserializeObject<Search.Data>(jsonData);


                switch (where)
                {
                    case "starts":

                        foreach (Search.Result hv in heroesVillians.results.ToList()) {

                            if (!(hv.name.ToLower().StartsWith(letters.ToLower())))
                            {
                                heroesVillians.results.Remove(hv);
                            }
                            Debug.WriteLine(hv.name.StartsWith(letters));
                            

                        }
                        return heroesVillians;                      

                    case "contains":
                        return heroesVillians;

                    default:
                        return heroesVillians;

                }
                

            }

            return null;
            

            


        }

        public List<Comparisons.Roots> HeroesVilliansStats(string id, string id2)
        {
            string baseURL = "https://superheroapi.com/api/";
            string method = "GET";
            List<Comparisons.Roots> comparisonsList = new();
            List<string> ids = new();
            ids.Add(id);
            ids.Add(id2);

            for (int i = 0; i < ids.Count; i++)
            {
                string endURL = "/" + ids[i];
                JObject parsedObject = GetJsonData(baseURL, endURL, method);
                string jsonData = parsedObject.ToString();

                Comparisons.Roots chosenCV = JsonConvert.DeserializeObject<Comparisons.Roots>(jsonData);
                if (chosenCV != null)
                {
                    comparisonsList.Add(chosenCV);
                }else
                {
                    break;
                }          
         
            }
            return comparisonsList;

        }




        public JObject GetJsonData(string baseURL, string endURL, string method)
        {
            string url = String.Format(baseURL + apiKey + endURL);
            WebRequest requestObject = WebRequest.Create(url);
            requestObject.Method = method;

            string jsonReturn = Fetch(requestObject);
            return JObject.Parse(jsonReturn);



        }



        public String Fetch (WebRequest requestObject)
        {
            try
            {
                HttpWebResponse responseObject = (HttpWebResponse)requestObject.GetResponse();
                string response = "";

                using (Stream stream = responseObject.GetResponseStream())
                {
                    StreamReader streamReader = new StreamReader(stream);
                    response = streamReader.ReadToEnd();
                    streamReader.Close();
                }

                return response;

            }
            catch (WebException error)
            {
                System.Console.WriteLine(error.Message);
                return error.ToString();
            }
        }

        
    }

}