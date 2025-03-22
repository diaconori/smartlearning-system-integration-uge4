namespace GadenavneWebservice.Handlers
{
    public static class DataHandler
    {
        private static readonly string addressesFilePath = "C:\\Users\\diaco\\Documents\\GitHub\\smartlearning-system-integration-uge4\\GadenavneWebservice\\GadenavneWebservice\\Data\\A370715.txt";

        public static string SelectAddressByCodes(string municipalCode, string streetCode)
        {
            string[] lines = File.ReadAllLines(addressesFilePath);
            return lines.FirstOrDefault(line => line.Contains(municipalCode) && line.Contains(streetCode)) ?? "";
        }

        public static string[] SelectAddressesByName(string name)
        {
            string[] lines = File.ReadAllLines(addressesFilePath);
            return lines.Where(line => line.Contains(name)).ToArray();
        }
    }
}