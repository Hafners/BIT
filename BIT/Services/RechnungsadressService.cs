using BIT.Data;
using System.Collections.ObjectModel;

namespace BIT.Services
{
    public class RechnungsadressService
    {
        public ObservableCollection<Rechnungsadresse> Adressen { get; set; }
        public RechnungsadressService()
        {
            if (Adressen == null)
            {
                Adressen = new ObservableCollection<Rechnungsadresse>()
                {
                    new Rechnungsadresse { Id = 1, Strasse = "Alte-Haupttorstrasse", hausNummer = "2", Land = "Deutschland", Name="Stadlmeier", Ort="Gendorf", PLZ="84508", Vorname="Martina"}
                };
            }
        }

        public void AddRechnungsadresse(Rechnungsadresse add)
        {
            Adressen.Add(add);
        }

        public void UpdateRechnungsadresse(Rechnungsadresse add)
        {
            var customer = Adressen.Single(x => x.Id == add.Id);
            customer = add;
        }

        public Rechnungsadresse GetRechnungsadresse(int id)
        {
            return Adressen.Single(x => x.Id == id);
        }
    }
}
