﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AntSimulator
{
    [XmlRoot("Fourmi")]
    public class Fourmi : PersonnageAbstrait
    {
        public override ZoneAbstraite ChoixZoneSuivante(List<AccesAbstrait> accesList)
        {
            throw new NotImplementedException();
        }
    }
}
