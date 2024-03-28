using Visitor_Pattern;

Village village = new Village();
Visitor santa = new Santa();
Element boysHouse = new BoysHouse();
Element girlsHouse = new GirlsHouse();
village.Add(boysHouse);
village.Add(girlsHouse);
village.Accept(santa);