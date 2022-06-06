namespace PLCLibrary
{
    public class SolarPanel
    {
        public static async Task<SolarRLModel> LoadSolarPanelData()
        {
            string url = "http://localhost:8087/get/modbus.0.holdingRegisters.40010_Solar_RL";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    SolarRLModel solarRL = await response.Content.ReadAsAsync<SolarRLModel>();
                    Console.WriteLine(solarRL);

                    return solarRL;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}