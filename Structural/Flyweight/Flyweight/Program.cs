using Flyweight_Film;

ActorMikeMyers actorMike = new ActorMikeMyers();
actorMike.Greeting("I am actor MikeMyers");

RoleAustinPowers roleAustin = new RoleAustinPowers(actorMike);
roleAustin.Greeting("I play AustinPowers role");

RoleDoctorEvil roleDoctor = new RoleDoctorEvil(actorMike);
roleDoctor.Greeting("I play DoctorEvil role");
