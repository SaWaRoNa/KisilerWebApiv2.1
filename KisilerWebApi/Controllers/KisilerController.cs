using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KisilerDbErisim;


namespace KisilerWebApi.Controllers
{
   
   [BasicAuthenticationFilter]
    
    public class KisilerController : ApiController
    {
        public IEnumerable<KisilerTable> Get()
        {
            using (dbKisilerEntities entities = new dbKisilerEntities())
            {
                return entities.KisilerTables.ToList();

            }
        }
     
       [BasicAuthenticationFilter]
        
        public KisilerTable Get(int id)
        {
            using (dbKisilerEntities entities = new dbKisilerEntities())
            {
                return entities.KisilerTables.FirstOrDefault(KisilerTable=> KisilerTable.KisiId == id);

            }
        }
    }
}
