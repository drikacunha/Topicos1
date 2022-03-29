using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
     class Celulares
    {
        protected PeçasBuilder celularesObject;

        public Celulares(PeçasBuilder celularObject)
        {
            this.celularesObject = celularObject;
        }
        public void construirCelular(String bateria, String camera, String gps, String visor)
        {
            celularesObject.CreateNewCelular();
            celularesObject.buildBateria(bateria);
            celularesObject.buildCamera(camera);
            celularesObject.buildGps(gps);
            celularesObject.buildVisor(visor);
        }

        public Fabrica GetFabrica()
        {
            return celularesObject.GetFabrica();
        }
    }
}
