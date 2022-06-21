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

    public class FBH
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

    public class Pufferspeicher
    {
        public static async Task<JsonModel> LoadPSOben()
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

        public static async Task<JsonModel> LoadPSUnten()
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


        public static async Task<JsonModel> LoadPSWW()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40011_Puffer_WW";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                    Console.WriteLine(respObject);
                    return respObject;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<JsonModel> LoadPSHeiz()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40012_Puffer_Heiz";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                    Console.WriteLine(respObject);
                    return respObject;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<JsonModel> LoadWWZulauf()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40008_WW_Zulauf";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                    Console.WriteLine(respObject);
                    return respObject;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
        ///////////////////////////////////Ausgang
        ///
        public class Ausgaenge
        {
            public static async Task<JsonModel> LoadPumpeSolar()
            {
                string url = "http://localhost:8087/get/modbus.0.coils.2_Pumpe_Solar";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                        Console.WriteLine(respObject);
                        return respObject;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<JsonModel> LoadPumpeZirku()
            {
                string url = "http://localhost:8087/get/modbus.0.coils.3_Pumpe_Zirku";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                        Console.WriteLine(respObject);
                        return respObject;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }


            public static async Task<JsonModel> LoadVentilSole1()
            {
                string url = "http://localhost:8087/get/modbus.0.coils.4_Ventil_Sole1";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                        Console.WriteLine(respObject);
                        return respObject;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<JsonModel> LoadVentilSolar1()
            {
                string url = "http://localhost:8087/get/modbus.0.coils.5_Ventil_Solar1";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                        Console.WriteLine(respObject);
                        return respObject;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<JsonModel> LoadHeizbandALM()
            {
                string url = "http://localhost:8087/get/modbus.0.coils.6_Heizband_ALM";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                        Console.WriteLine(respObject);
                        return respObject;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<JsonModel> LoadPumpeSole()
            {
                string url = "http://localhost:8087/get/modbus.0.coils.7_Pumpe_Sole";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                        Console.WriteLine(respObject);
                        return respObject;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<JsonModel> LoadVentilWW()
            {
                string url = "http://localhost:8087/get/modbus.0.coils.8_Ventil_WW";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                        Console.WriteLine(respObject);
                        return respObject;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<JsonModel> LoadPumpeHzkr()
            {
                string url = "http://localhost:8087/get/modbus.0.coils.9_Pumpe_Hzkr";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                        Console.WriteLine(respObject);
                        return respObject;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<JsonModel> LoadWPAnf()
            {
                string url = "http://localhost:8087/get/modbus.0.coils.10_WP_Anf";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                        Console.WriteLine(respObject);
                        return respObject;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<JsonModel> LoadMischerAuf()
            {
                string url = "http://localhost:8087/get/modbus.0.coils.11_Mischer_auf";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                        Console.WriteLine(respObject);
                        return respObject;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<JsonModel> LoadMischerZu()
            {
                string url = "http://localhost:8087/get/modbus.0.coils.12_Mischer_zu";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                        Console.WriteLine(respObject);
                        return respObject;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<JsonModel> LoadVentilSole2()
            {
                string url = "http://localhost:8087/get/modbus.0.coils.13_Ventil_Sole2";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                        Console.WriteLine(respObject);
                        return respObject;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<JsonModel> LoadVentilSolar2()
            {
                string url = "http://localhost:8087/get/modbus.0.coils.14_Ventil_Solar2";

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
                        Console.WriteLine(respObject);
                        return respObject;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

        //public static async Task<JsonModel> LoadVentilSolar2()
        //{
        //    string url = "http://localhost:8087/set/modbus.0.coils.14_Ventil_Solar2";

        //    using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
        //    {
        //        if (response.IsSuccessStatusCode)
        //        {
        //            JsonModel respObject = await response.Content.ReadAsAsync<JsonModel>();
        //            Console.WriteLine(respObject);
        //            return respObject;
        //        }
        //        else
        //        {
        //            throw new Exception(response.ReasonPhrase);
        //        }
        //    }
        //}
    }
        }
