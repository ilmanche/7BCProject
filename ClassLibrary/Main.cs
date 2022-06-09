using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SolarPanel
    {
        public static async Task<JsonModel> LoadSolarPanelData()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40010_Solar_RL";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                    Console.WriteLine(respObject);

                    return respObject;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }

    public class Aussenluft
    {
        public static async Task<JsonModel> LoadAlmAussen()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40009_ALM_aussen";
            
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                    Console.WriteLine(respObject);
                    return respObject;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<JsonModel> LoadTempAussen()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40014_Aussen";
            
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                    Console.WriteLine(respObject);
                    return respObject;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }

    public class Fussbodenheizung
    {
        public static async Task<JsonModel> LoadFbhVL()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40002_FBH_VL";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                    Console.WriteLine(respObject);

                    return respObject;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<JsonModel> LoadFbhRL()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40003_FBH_VR";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                    Console.WriteLine(respObject);

                    return respObject;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }

    public class Waermepumpe
    {
        public static async Task<JsonModel> LoadWPinnen()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40013_WP_innen";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                    Console.WriteLine(respObject);

                    return respObject;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<JsonModel> LoadSoleVL()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40004_Sole_VL";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                    Console.WriteLine(respObject);

                    return respObject;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<JsonModel> LoadSoleRL()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40005_Sole_RL";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                    Console.WriteLine(respObject);

                    return respObject;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }

    public class Zisterne
    {
        public static async Task<JsonModel> LoadZisUnten()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40016_Zist_unten";
            
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                    Console.WriteLine(respObject);
                    return respObject;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<JsonModel> LoadZisOben()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40017_Zist_oben";
            
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                    Console.WriteLine(respObject);
                    return respObject;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }

    public class Prozessspeicher
    {
        public static async Task<JsonModel> LoadProzOben()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40007_PS_oben";
            
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                    Console.WriteLine(respObject);
                    return respObject;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<JsonModel> LoadProzUnten()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40006_PS_unten";
            
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                    Console.WriteLine(respObject);
                    return respObject;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}