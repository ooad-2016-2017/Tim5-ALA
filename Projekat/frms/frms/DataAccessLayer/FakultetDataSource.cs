using frms.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Microsoft.WindowsAzure.MobileServices;

namespace frms.DataAccessLayer
{
    class FakultetDataSource
    {

        public static MobileServiceClient MobileService = new
            MobileServiceClient("https://frms.azurewebsites.net");
        
        public IMobileServiceTable<Korisnik> Korisnici { get; } = MobileService.GetTable<Korisnik>();
        public IMobileServiceTable<Grupa> Grupe { get; } = MobileService.GetTable<Grupa>();
        public IMobileServiceTable<Sala> Sale { get; } = MobileService.GetTable<Sala>();
        public IMobileServiceTable<Laboratorij> Laboratoriji { get; } = MobileService.GetTable<Laboratorij>();
        public IMobileServiceTable<Zahtjev> Zahtjevi { get; } = MobileService.GetTable<Zahtjev>();
        public IMobileServiceTable<Termin> Termini { get; } = MobileService.GetTable<Termin>();
        
        
        
        public async Task<Sala> DajSaluById(string id)
        {
            var list = await Sale.Where(s => s.ID == id).ToListAsync();

            return list.Count > 0 ? list[0] : null;
        }

        public async Task<Korisnik> DajKorisnikaById(string id)
        {
            var list = await Korisnici.Where(s => s.ID == id).ToListAsync();

            return list.Count > 0 ? list[0] : null;
        }

        public async Task<Grupa> DajGrupuById(string id)
        {
            var list = await Grupe.Where(s => s.ID == id).ToListAsync();

            return list.Count > 0 ? list[0] : null;
        }

        public async Task<Zahtjev> DajZahtjevById(string id)
        {
            var list = await Zahtjevi.Where(s => s.ID == id).ToListAsync();

            return list.Count > 0 ? list[0] : null;
        }

        

    }
}
