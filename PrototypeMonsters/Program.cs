
using PrototypeMonsters.Instanciables;

Zombie michaelJackson = new Zombie {Id = "MJ1" };
Mummy laMomia = new Mummy { Id = "LM1" };
Vampire dracula = new Vampire { Id = "DL1" };

michaelJackson.Attack();
laMomia.Attack();
dracula.Attack();



Zombie walkingDead = (Zombie)michaelJackson.Clone();
Mummy tutankamon = (Mummy)laMomia.Clone();
Vampire alucard = (Vampire)dracula.Clone();



walkingDead.Id = "WD1";
tutankamon.Id = "TKM";
alucard.Id = "AL1";


walkingDead.Attack();
tutankamon.Attack();
alucard.Attack();
