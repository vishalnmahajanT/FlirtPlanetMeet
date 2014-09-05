//--------------------------------------------------------------------------------
//
// Core.Business.GeoBus.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;
using Core.Data;

//--------------------------------------------------------------------------------

namespace Core.Business
{
	public class GeoBus : BusinessBase
	{
		//----------------------------------------
		// Find matching cities using user entry

		public static List<Location> FindMatchingCities(List<Country> countries, string countryName, string regionName, string cityName)
		{
			string[] codes = GetCountryRegionCode(countries, countryName, regionName);

			NewWebserviceCall();

			while (ReturnVal == null)
			{
				if (Counter == 5)
					return null;

				ReturnVal = WebService.CallWebservice(EncodeString("FindMatchingCities", "{\"CityName\":\"" + cityName + "\", \"CountryCode\":\"" + codes[0] +
																		"\", \"RegionCode\":\"" + codes[1] + "\"}"));
				++Counter;
			}

			List<Location> locations = JsonConvert.DeserializeObject<List<Location>>(DecodeString(ReturnVal));

			var query = (from l in locations
						 orderby l.City
						 group l by l.City).ToList();

			List<Location> locList = new List<Location>();

			// Loop through stupid group by structure to get useful information
			foreach (var locGroup in query)
			{
				foreach (Location loc in locGroup)
				{
					locList.Add(loc);
					break;
				}
			}

			return locList;
		}

		//----------------------------------------
		// Get Country/Region Codes needed for database query

		private static string[] GetCountryRegionCode(List<Country> countries, string countryName, string regionName)
		{
			string[] codes = new string[2];

			Country country = countries.Single(c => c.CountryName == countryName);
			codes[0] = country.CountryCode;
			codes[1] = country.Regions.Single(r => r.RegionName == regionName).RegionCode;

			return codes;
		}

		//----------------------------------------

		public static List<Country> GetCountryList()
		{
			List<Country> countryList = new List<Country>();
			Country country;

			// United States
			country = new Country("United States", "US");
			country.Regions.Add(new Region("AK", "Alaska"));
			country.Regions.Add(new Region("AL", "Alabama"));
			country.Regions.Add(new Region("AR", "Arkansas"));
			country.Regions.Add(new Region("AZ", "Arizona"));
			country.Regions.Add(new Region("CA", "California"));
			country.Regions.Add(new Region("CO", "Colorado"));
			country.Regions.Add(new Region("CT", "Connecticut"));
			country.Regions.Add(new Region("DC", "District of Columbia"));
			country.Regions.Add(new Region("DE", "Delaware"));
			country.Regions.Add(new Region("FL", "Florida"));
			country.Regions.Add(new Region("FM", "Federated States of Micronesia"));
			country.Regions.Add(new Region("GA", "Georgia"));
			country.Regions.Add(new Region("HI", "Hawaii"));
			country.Regions.Add(new Region("IA", "Iowa"));
			country.Regions.Add(new Region("ID", "Idaho"));
			country.Regions.Add(new Region("IL", "Illinois"));
			country.Regions.Add(new Region("IN", "Indiana"));
			country.Regions.Add(new Region("KS", "Kansas"));
			country.Regions.Add(new Region("KY", "Kentucky"));
			country.Regions.Add(new Region("LA", "Louisiana"));
			country.Regions.Add(new Region("MA", "Massachusetts"));
			country.Regions.Add(new Region("MD", "Maryland"));
			country.Regions.Add(new Region("ME", "Maine"));
			country.Regions.Add(new Region("MI", "Michigan"));
			country.Regions.Add(new Region("MN", "Minnesota"));
			country.Regions.Add(new Region("MO", "Missouri"));
			country.Regions.Add(new Region("MS", "Mississippi"));
			country.Regions.Add(new Region("MT", "Montana"));
			country.Regions.Add(new Region("NC", "North Carolina"));
			country.Regions.Add(new Region("ND", "North Dakota"));
			country.Regions.Add(new Region("NE", "Nebraska"));
			country.Regions.Add(new Region("NH", "New Hampshire"));
			country.Regions.Add(new Region("NJ", "New Jersey"));
			country.Regions.Add(new Region("NM", "New Mexico"));
			country.Regions.Add(new Region("NV", "Nevada"));
			country.Regions.Add(new Region("NY", "New York"));
			country.Regions.Add(new Region("OH", "Ohio"));
			country.Regions.Add(new Region("OK", "Oklahoma"));
			country.Regions.Add(new Region("OR", "Oregon"));
			country.Regions.Add(new Region("PA", "Pennsylvania"));
			country.Regions.Add(new Region("PR", "Puerto Rico"));
			country.Regions.Add(new Region("PW", "Palau"));
			country.Regions.Add(new Region("RI", "Rhode Island"));
			country.Regions.Add(new Region("SC", "South Carolina"));
			country.Regions.Add(new Region("SD", "South Dakota"));
			country.Regions.Add(new Region("TN", "Tennessee"));
			country.Regions.Add(new Region("TX", "Texas"));
			country.Regions.Add(new Region("UT", "Utah"));
			country.Regions.Add(new Region("VA", "Virginia"));
			country.Regions.Add(new Region("VT", "Vermont"));
			country.Regions.Add(new Region("WA", "Washington"));
			country.Regions.Add(new Region("WI", "Wisconsin"));
			country.Regions.Add(new Region("WV", "West Virginia"));
			country.Regions.Add(new Region("WY", "Wyoming"));
			countryList.Add(country);

			// Afghanistan
			country = new Country("Afghanistan", "AF");
			country.Regions.Add(new Region("01", "Badakhshan"));
			country.Regions.Add(new Region("02", "Badghis"));
			country.Regions.Add(new Region("03", "Baghlan"));
			country.Regions.Add(new Region("05", "Bamian"));
			country.Regions.Add(new Region("06", "Farah"));
			country.Regions.Add(new Region("07", "Faryab"));
			country.Regions.Add(new Region("08", "Ghazni"));
			country.Regions.Add(new Region("09", "Ghowr"));
			country.Regions.Add(new Region("10", "Helmand"));
			country.Regions.Add(new Region("11", "Herat"));
			country.Regions.Add(new Region("13", "Kabol"));
			country.Regions.Add(new Region("14", "Kapisa"));
			country.Regions.Add(new Region("17", "Lowgar"));
			country.Regions.Add(new Region("18", "Nangarhar"));
			country.Regions.Add(new Region("19", "Nimruz"));
			country.Regions.Add(new Region("23", "Kandahar"));
			country.Regions.Add(new Region("24", "Kondoz"));
			country.Regions.Add(new Region("26", "Takhar"));
			country.Regions.Add(new Region("27", "Vardak"));
			country.Regions.Add(new Region("28", "Zabol"));
			country.Regions.Add(new Region("29", "Paktika"));
			country.Regions.Add(new Region("30", "Balkh"));
			country.Regions.Add(new Region("31", "Jowzjan"));
			country.Regions.Add(new Region("32", "Samangan"));
			country.Regions.Add(new Region("33", "Sar-e Pol"));
			country.Regions.Add(new Region("34", "Konar"));
			country.Regions.Add(new Region("35", "Laghman"));
			country.Regions.Add(new Region("36", "Paktia"));
			country.Regions.Add(new Region("37", "Khowst"));
			country.Regions.Add(new Region("38", "Nurestan"));
			country.Regions.Add(new Region("39", "Oruzgan"));
			country.Regions.Add(new Region("40", "Parvan"));
			country.Regions.Add(new Region("41", "Daykondi"));
			country.Regions.Add(new Region("42", "Panjshir"));
			countryList.Add(country);

			// Albania
			country = new Country("Albania", "AL");
			country.Regions.Add(new Region("40", "Berat"));
			country.Regions.Add(new Region("41", "Diber"));
			country.Regions.Add(new Region("42", "Durres"));
			country.Regions.Add(new Region("43", "Elbasan"));
			country.Regions.Add(new Region("44", "Fier"));
			country.Regions.Add(new Region("45", "Gjirokaster"));
			country.Regions.Add(new Region("46", "Korce"));
			country.Regions.Add(new Region("47", "Kukes"));
			country.Regions.Add(new Region("48", "Lezhe"));
			country.Regions.Add(new Region("49", "Shkoder"));
			country.Regions.Add(new Region("50", "Tirane"));
			country.Regions.Add(new Region("51", "Vlore"));
			countryList.Add(country);

			// Algeria
			country = new Country("Algeria", "DZ");
			country.Regions.Add(new Region("01", "Alger"));
			country.Regions.Add(new Region("03", "Batna"));
			country.Regions.Add(new Region("04", "Constantine"));
			country.Regions.Add(new Region("06", "Medea"));
			country.Regions.Add(new Region("07", "Mostaganem"));
			country.Regions.Add(new Region("09", "Oran"));
			country.Regions.Add(new Region("10", "Saida"));
			country.Regions.Add(new Region("12", "Setif"));
			country.Regions.Add(new Region("13", "Tiaret"));
			country.Regions.Add(new Region("14", "Tizi Ouzou"));
			country.Regions.Add(new Region("15", "Tlemcen"));
			country.Regions.Add(new Region("18", "Bejaia"));
			country.Regions.Add(new Region("19", "Biskra"));
			country.Regions.Add(new Region("20", "Blida"));
			country.Regions.Add(new Region("21", "Bouira"));
			country.Regions.Add(new Region("22", "Djelfa"));
			country.Regions.Add(new Region("23", "Guelma"));
			country.Regions.Add(new Region("24", "Jijel"));
			country.Regions.Add(new Region("25", "Laghouat"));
			country.Regions.Add(new Region("26", "Mascara"));
			country.Regions.Add(new Region("27", "M'sila"));
			country.Regions.Add(new Region("29", "Oum el Bouaghi"));
			country.Regions.Add(new Region("30", "Sidi Bel Abbes"));
			country.Regions.Add(new Region("31", "Skikda"));
			country.Regions.Add(new Region("33", "Tebessa"));
			country.Regions.Add(new Region("34", "Adrar"));
			country.Regions.Add(new Region("35", "Ain Defla"));
			country.Regions.Add(new Region("36", "Ain Temouchent"));
			country.Regions.Add(new Region("37", "Annaba"));
			country.Regions.Add(new Region("38", "Bechar"));
			country.Regions.Add(new Region("39", "Bordj Bou Arreridj"));
			country.Regions.Add(new Region("40", "Boumerdes"));
			country.Regions.Add(new Region("41", "Chlef"));
			country.Regions.Add(new Region("42", "El Bayadh"));
			country.Regions.Add(new Region("43", "El Oued"));
			country.Regions.Add(new Region("44", "El Tarf"));
			country.Regions.Add(new Region("45", "Ghardaia"));
			country.Regions.Add(new Region("46", "Illizi"));
			country.Regions.Add(new Region("47", "Khenchela"));
			country.Regions.Add(new Region("48", "Mila"));
			country.Regions.Add(new Region("49", "Naama"));
			country.Regions.Add(new Region("50", "Ouargla"));
			country.Regions.Add(new Region("51", "Relizane"));
			country.Regions.Add(new Region("52", "Souk Ahras"));
			country.Regions.Add(new Region("53", "Tamanghasset"));
			country.Regions.Add(new Region("54", "Tindouf"));
			country.Regions.Add(new Region("55", "Tipaza"));
			country.Regions.Add(new Region("56", "Tissemsilt"));
			countryList.Add(country);

			// American Samoa -------------------------------------------------------------------
			country = new Country("American Samoa", "AS");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Andorra
			country = new Country("Andorra", "AD");
			country.Regions.Add(new Region("02", "Canillo"));
			country.Regions.Add(new Region("03", "Encamp"));
			country.Regions.Add(new Region("04", "La Massana"));
			country.Regions.Add(new Region("05", "Ordino"));
			country.Regions.Add(new Region("06", "Sant Julia de Loria"));
			country.Regions.Add(new Region("07", "Andorra la Vella"));
			country.Regions.Add(new Region("08", "Escaldes-Engordany"));
			countryList.Add(country);

			// Angola
			country = new Country("Angola", "AO");
			country.Regions.Add(new Region("01", "Benguela"));
			country.Regions.Add(new Region("02", "Bie"));
			country.Regions.Add(new Region("03", "Cabinda"));
			country.Regions.Add(new Region("04", "Cuando Cubango"));
			country.Regions.Add(new Region("05", "Cuanza Norte"));
			country.Regions.Add(new Region("06", "Cuanza Sul"));
			country.Regions.Add(new Region("07", "Cunene"));
			country.Regions.Add(new Region("08", "Huambo"));
			country.Regions.Add(new Region("09", "Huila"));
			country.Regions.Add(new Region("12", "Malanje"));
			country.Regions.Add(new Region("13", "Namibe"));
			country.Regions.Add(new Region("14", "Moxico"));
			country.Regions.Add(new Region("15", "Uige"));
			country.Regions.Add(new Region("16", "Zaire"));
			country.Regions.Add(new Region("17", "Lunda Norte"));
			country.Regions.Add(new Region("18", "Lunda Sul"));
			country.Regions.Add(new Region("19", "Bengo"));
			country.Regions.Add(new Region("20", "Luanda"));
			countryList.Add(country);

			// Anguilla -------------------------------------------------------------------
			country = new Country("Anguilla", "AI");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Antarctica -------------------------------------------------------------------
			//country = new Country("Antarctica", "AQ");
			//countryList.Add(country);

			// Antigua and Barbuda
			country = new Country("Antigua and Barbuda", "AG");
			country.Regions.Add(new Region("01", "Barbuda"));
			country.Regions.Add(new Region("03", "Saint George"));
			country.Regions.Add(new Region("04", "Saint John"));
			country.Regions.Add(new Region("05", "Saint Mary"));
			country.Regions.Add(new Region("06", "Saint Paul"));
			country.Regions.Add(new Region("07", "Saint Peter"));
			country.Regions.Add(new Region("08", "Saint Philip"));
			country.Regions.Add(new Region("09", "Redonda"));
			countryList.Add(country);

			// Argentina
			country = new Country("Argentina", "AR");
			country.Regions.Add(new Region("01", "Buenos Aires"));
			country.Regions.Add(new Region("02", "Catamarca"));
			country.Regions.Add(new Region("03", "Chaco"));
			country.Regions.Add(new Region("04", "Chubut"));
			country.Regions.Add(new Region("05", "Cordoba"));
			country.Regions.Add(new Region("06", "Corrientes"));
			country.Regions.Add(new Region("07", "Distrito Federal"));
			country.Regions.Add(new Region("08", "Entre Rios"));
			country.Regions.Add(new Region("09", "Formosa"));
			country.Regions.Add(new Region("10", "Jujuy"));
			country.Regions.Add(new Region("11", "La Pampa"));
			country.Regions.Add(new Region("12", "La Rioja"));
			country.Regions.Add(new Region("13", "Mendoza"));
			country.Regions.Add(new Region("14", "Misiones"));
			country.Regions.Add(new Region("15", "Neuquen"));
			country.Regions.Add(new Region("16", "Rio Negro"));
			country.Regions.Add(new Region("17", "Salta"));
			country.Regions.Add(new Region("18", "San Juan"));
			country.Regions.Add(new Region("19", "San Luis"));
			country.Regions.Add(new Region("20", "Santa Cruz"));
			country.Regions.Add(new Region("21", "Santa Fe"));
			country.Regions.Add(new Region("22", "Santiago del Estero"));
			country.Regions.Add(new Region("23", "Tierra del Fuego"));
			country.Regions.Add(new Region("24", "Tucuman"));
			countryList.Add(country);

			// Armenia
			country = new Country("Armenia", "AM");
			country.Regions.Add(new Region("01", "Aragatsotn"));
			country.Regions.Add(new Region("02", "Ararat"));
			country.Regions.Add(new Region("03", "Armavir"));
			country.Regions.Add(new Region("04", "Geghark'unik'"));
			country.Regions.Add(new Region("05", "Kotayk'"));
			country.Regions.Add(new Region("06", "Lorri"));
			country.Regions.Add(new Region("07", "Shirak"));
			country.Regions.Add(new Region("08", "Syunik'"));
			country.Regions.Add(new Region("09", "Tavush"));
			country.Regions.Add(new Region("10", "Vayots' Dzor"));
			country.Regions.Add(new Region("11", "Yerevan"));
			countryList.Add(country);

			// Aruba -------------------------------------------------------------------
			country = new Country("Aruba", "AW");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Australia
			country = new Country("Australia", "AU");
			country.Regions.Add(new Region("01", "Australian Capital Territory"));
			country.Regions.Add(new Region("02", "New South Wales"));
			country.Regions.Add(new Region("03", "Northern Territory"));
			country.Regions.Add(new Region("04", "Queensland"));
			country.Regions.Add(new Region("05", "South Australia"));
			country.Regions.Add(new Region("06", "Tasmania"));
			country.Regions.Add(new Region("07", "Victoria"));
			country.Regions.Add(new Region("08", "Western Australia"));
			countryList.Add(country);

			// Austria
			country = new Country("Austria", "AT");
			country.Regions.Add(new Region("01", "Burgenland"));
			country.Regions.Add(new Region("02", "Karnten"));
			country.Regions.Add(new Region("03", "Niederosterreich"));
			country.Regions.Add(new Region("04", "Oberosterreich"));
			country.Regions.Add(new Region("05", "Salzburg"));
			country.Regions.Add(new Region("06", "Steiermark"));
			country.Regions.Add(new Region("07", "Tirol"));
			country.Regions.Add(new Region("08", "Vorarlberg"));
			country.Regions.Add(new Region("09", "Wien"));
			countryList.Add(country);

			// Azerbaijan
			country = new Country("Azerbaijan", "AZ");
			country.Regions.Add(new Region("01", "Abseron"));
			country.Regions.Add(new Region("02", "Agcabadi"));
			country.Regions.Add(new Region("03", "Agdam"));
			country.Regions.Add(new Region("04", "Agdas"));
			country.Regions.Add(new Region("05", "Agstafa"));
			country.Regions.Add(new Region("06", "Agsu"));
			country.Regions.Add(new Region("07", "Ali Bayramli"));
			country.Regions.Add(new Region("08", "Astara"));
			country.Regions.Add(new Region("09", "Baki"));
			country.Regions.Add(new Region("10", "Balakan"));
			country.Regions.Add(new Region("11", "Barda"));
			country.Regions.Add(new Region("12", "Beylaqan"));
			country.Regions.Add(new Region("13", "Bilasuvar"));
			country.Regions.Add(new Region("14", "Cabrayil"));
			country.Regions.Add(new Region("15", "Calilabad"));
			country.Regions.Add(new Region("16", "Daskasan"));
			country.Regions.Add(new Region("17", "Davaci"));
			country.Regions.Add(new Region("18", "Fuzuli"));
			country.Regions.Add(new Region("19", "Gadabay"));
			country.Regions.Add(new Region("20", "Ganca"));
			country.Regions.Add(new Region("21", "Goranboy"));
			country.Regions.Add(new Region("22", "Goycay"));
			country.Regions.Add(new Region("23", "Haciqabul"));
			country.Regions.Add(new Region("24", "Imisli"));
			country.Regions.Add(new Region("25", "Ismayilli"));
			country.Regions.Add(new Region("26", "Kalbacar"));
			country.Regions.Add(new Region("27", "Kurdamir"));
			country.Regions.Add(new Region("28", "Lacin"));
			country.Regions.Add(new Region("29", "Lankaran"));
			country.Regions.Add(new Region("30", "Lankaran"));
			country.Regions.Add(new Region("31", "Lerik"));
			country.Regions.Add(new Region("32", "Masalli"));
			country.Regions.Add(new Region("33", "Mingacevir"));
			country.Regions.Add(new Region("34", "Naftalan"));
			country.Regions.Add(new Region("35", "Naxcivan"));
			country.Regions.Add(new Region("36", "Neftcala"));
			country.Regions.Add(new Region("37", "Oguz"));
			country.Regions.Add(new Region("38", "Qabala"));
			country.Regions.Add(new Region("39", "Qax"));
			country.Regions.Add(new Region("40", "Qazax"));
			country.Regions.Add(new Region("41", "Qobustan"));
			country.Regions.Add(new Region("42", "Quba"));
			country.Regions.Add(new Region("43", "Qubadli"));
			country.Regions.Add(new Region("44", "Qusar"));
			country.Regions.Add(new Region("45", "Saatli"));
			country.Regions.Add(new Region("46", "Sabirabad"));
			country.Regions.Add(new Region("47", "Saki"));
			country.Regions.Add(new Region("48", "Saki"));
			country.Regions.Add(new Region("49", "Salyan"));
			country.Regions.Add(new Region("50", "Samaxi"));
			country.Regions.Add(new Region("51", "Samkir"));
			country.Regions.Add(new Region("52", "Samux"));
			country.Regions.Add(new Region("53", "Siyazan"));
			country.Regions.Add(new Region("54", "Sumqayit"));
			country.Regions.Add(new Region("55", "Susa"));
			country.Regions.Add(new Region("56", "Susa"));
			country.Regions.Add(new Region("57", "Tartar"));
			country.Regions.Add(new Region("58", "Tovuz"));
			country.Regions.Add(new Region("59", "Ucar"));
			country.Regions.Add(new Region("60", "Xacmaz"));
			country.Regions.Add(new Region("61", "Xankandi"));
			country.Regions.Add(new Region("62", "Xanlar"));
			country.Regions.Add(new Region("63", "Xizi"));
			country.Regions.Add(new Region("64", "Xocali"));
			country.Regions.Add(new Region("65", "Xocavand"));
			country.Regions.Add(new Region("66", "Yardimli"));
			country.Regions.Add(new Region("67", "Yevlax"));
			country.Regions.Add(new Region("68", "Yevlax"));
			country.Regions.Add(new Region("69", "Zangilan"));
			country.Regions.Add(new Region("70", "Zaqatala"));
			country.Regions.Add(new Region("71", "Zardab"));
			countryList.Add(country);

			// Bahamas
			country = new Country("Bahamas", "BS");
			country.Regions.Add(new Region("05", "Bimini"));
			country.Regions.Add(new Region("06", "Cat Island"));
			country.Regions.Add(new Region("10", "Exuma"));
			country.Regions.Add(new Region("13", "Inagua"));
			country.Regions.Add(new Region("15", "Long Island"));
			country.Regions.Add(new Region("16", "Mayaguana"));
			country.Regions.Add(new Region("18", "Ragged Island"));
			country.Regions.Add(new Region("22", "Harbour Island"));
			country.Regions.Add(new Region("23", "New Providence"));
			country.Regions.Add(new Region("24", "Acklins and Crooked Islands"));
			country.Regions.Add(new Region("25", "Freeport"));
			country.Regions.Add(new Region("26", "Fresh Creek"));
			country.Regions.Add(new Region("27", "Governor's Harbour"));
			country.Regions.Add(new Region("28", "Green Turtle Cay"));
			country.Regions.Add(new Region("29", "High Rock"));
			country.Regions.Add(new Region("30", "Kemps Bay"));
			country.Regions.Add(new Region("31", "Marsh Harbour"));
			country.Regions.Add(new Region("32", "Nichollstown and Berry Islands"));
			country.Regions.Add(new Region("33", "Rock Sound"));
			country.Regions.Add(new Region("34", "Sandy Point"));
			country.Regions.Add(new Region("35", "San Salvador and Rum Cay"));
			countryList.Add(country);

			// Bahrain
			country = new Country("Bahrain", "BH");
			country.Regions.Add(new Region("01", "Al Hadd"));
			country.Regions.Add(new Region("02", "Al Manamah"));
			country.Regions.Add(new Region("05", "Jidd Hafs"));
			country.Regions.Add(new Region("06", "Sitrah"));
			country.Regions.Add(new Region("08", "Al Mintaqah al Gharbiyah"));
			country.Regions.Add(new Region("09", "Mintaqat Juzur Hawar"));
			country.Regions.Add(new Region("10", "Al Mintaqah ash Shamaliyah"));
			country.Regions.Add(new Region("11", "Al Mintaqah al Wusta"));
			country.Regions.Add(new Region("12", "Madinat"));
			country.Regions.Add(new Region("13", "Ar Rifa"));
			country.Regions.Add(new Region("14", "Madinat Hamad"));
			country.Regions.Add(new Region("15", "Al Muharraq"));
			country.Regions.Add(new Region("16", "Al Asimah"));
			country.Regions.Add(new Region("17", "Al Janubiyah"));
			country.Regions.Add(new Region("18", "Ash Shamaliyah"));
			country.Regions.Add(new Region("19", "Al Wusta"));
			countryList.Add(country);

			// Bangladesh
			country = new Country("Bangladesh", "BD");
			country.Regions.Add(new Region("81", "Dhaka"));
			country.Regions.Add(new Region("82", "Khulna"));
			country.Regions.Add(new Region("83", "Rajshahi"));
			country.Regions.Add(new Region("84", "Chittagong"));
			country.Regions.Add(new Region("85", "Barisal"));
			country.Regions.Add(new Region("86", "Sylhet"));
			countryList.Add(country);

			// Barbados
			country = new Country("Barbados", "BB");
			country.Regions.Add(new Region("01", "Christ Church"));
			country.Regions.Add(new Region("02", "Saint Andrew"));
			country.Regions.Add(new Region("03", "Saint George"));
			country.Regions.Add(new Region("04", "Saint James"));
			country.Regions.Add(new Region("05", "Saint John"));
			country.Regions.Add(new Region("06", "Saint Joseph"));
			country.Regions.Add(new Region("07", "Saint Lucy"));
			country.Regions.Add(new Region("08", "Saint Michael"));
			country.Regions.Add(new Region("09", "Saint Peter"));
			country.Regions.Add(new Region("10", "Saint Philip"));
			country.Regions.Add(new Region("11", "Saint Thomas"));
			countryList.Add(country);

			// Belarus
			country = new Country("Belarus", "BY");
			country.Regions.Add(new Region("01", "Brestskaya Voblasts'"));
			country.Regions.Add(new Region("02", "Homyel'skaya Voblasts'"));
			country.Regions.Add(new Region("03", "Hrodzyenskaya Voblasts'"));
			country.Regions.Add(new Region("04", "Minsk"));
			country.Regions.Add(new Region("05", "Minskaya Voblasts'"));
			country.Regions.Add(new Region("06", "Mahilyowskaya Voblasts'"));
			country.Regions.Add(new Region("07", "Vitsyebskaya Voblasts'"));
			countryList.Add(country);

			// Belgium
			country = new Country("Belgium", "BE");
			country.Regions.Add(new Region("01", "Antwerpen"));
			country.Regions.Add(new Region("03", "Hainaut"));
			country.Regions.Add(new Region("04", "Liege"));
			country.Regions.Add(new Region("05", "Limburg"));
			country.Regions.Add(new Region("06", "Luxembourg"));
			country.Regions.Add(new Region("07", "Namur"));
			country.Regions.Add(new Region("08", "Oost-Vlaanderen"));
			country.Regions.Add(new Region("09", "West-Vlaanderen"));
			country.Regions.Add(new Region("10", "Brabant Wallon"));
			country.Regions.Add(new Region("11", "Brussels Hoofdstedelijk Gewest"));
			country.Regions.Add(new Region("12", "Vlaams-Brabant"));
			country.Regions.Add(new Region("13", "Flanders"));
			country.Regions.Add(new Region("14", "Wallonia"));
			countryList.Add(country);

			// Belize
			country = new Country("Belize", "BZ");
			country.Regions.Add(new Region("01", "Belize"));
			country.Regions.Add(new Region("02", "Cayo"));
			country.Regions.Add(new Region("03", "Corozal"));
			country.Regions.Add(new Region("04", "Orange Walk"));
			country.Regions.Add(new Region("05", "Stann Creek"));
			country.Regions.Add(new Region("06", "Toledo"));
			countryList.Add(country);

			// Benin
			country = new Country("Benin", "BJ");
			country.Regions.Add(new Region("07", "Alibori"));
			country.Regions.Add(new Region("08", "Atakora"));
			country.Regions.Add(new Region("09", "Atlanyique"));
			country.Regions.Add(new Region("10", "Borgou"));
			country.Regions.Add(new Region("11", "Collines"));
			country.Regions.Add(new Region("12", "Kouffo"));
			country.Regions.Add(new Region("13", "Donga"));
			country.Regions.Add(new Region("14", "Littoral"));
			country.Regions.Add(new Region("15", "Mono"));
			country.Regions.Add(new Region("16", "Oueme"));
			country.Regions.Add(new Region("17", "Plateau"));
			country.Regions.Add(new Region("18", "Zou"));
			countryList.Add(country);

			// Bermuda
			country = new Country("Bermuda", "BM");
			country.Regions.Add(new Region("01", "Devonshire"));
			country.Regions.Add(new Region("02", "Hamilton"));
			country.Regions.Add(new Region("03", "Hamilton"));
			country.Regions.Add(new Region("04", "Paget"));
			country.Regions.Add(new Region("05", "Pembroke"));
			country.Regions.Add(new Region("06", "Saint George"));
			country.Regions.Add(new Region("07", "Saint George's"));
			country.Regions.Add(new Region("08", "Sandys"));
			country.Regions.Add(new Region("09", "Smiths"));
			country.Regions.Add(new Region("10", "Southampton"));
			country.Regions.Add(new Region("11", "Warwick"));
			countryList.Add(country);

			// Bhutan
			country = new Country("Bhutan", "BT");
			country.Regions.Add(new Region("05", "Bumthang"));
			country.Regions.Add(new Region("06", "Chhukha"));
			country.Regions.Add(new Region("07", "Chirang"));
			country.Regions.Add(new Region("08", "Daga"));
			country.Regions.Add(new Region("09", "Geylegphug"));
			country.Regions.Add(new Region("10", "Ha"));
			country.Regions.Add(new Region("11", "Lhuntshi"));
			country.Regions.Add(new Region("12", "Mongar"));
			country.Regions.Add(new Region("13", "Paro"));
			country.Regions.Add(new Region("14", "Pemagatsel"));
			country.Regions.Add(new Region("15", "Punakha"));
			country.Regions.Add(new Region("16", "Samchi"));
			country.Regions.Add(new Region("17", "Samdrup"));
			country.Regions.Add(new Region("18", "Shemgang"));
			country.Regions.Add(new Region("19", "Tashigang"));
			country.Regions.Add(new Region("20", "Thimphu"));
			country.Regions.Add(new Region("21", "Tongsa"));
			country.Regions.Add(new Region("22", "Wangdi Phodrang"));
			countryList.Add(country);

			// Bolivia
			country = new Country("Bolivia", "BO");
			country.Regions.Add(new Region("01", "Chuquisaca"));
			country.Regions.Add(new Region("02", "Cochabamba"));
			country.Regions.Add(new Region("03", "El Beni"));
			country.Regions.Add(new Region("04", "La Paz"));
			country.Regions.Add(new Region("05", "Oruro"));
			country.Regions.Add(new Region("06", "Pando"));
			country.Regions.Add(new Region("07", "Potosi"));
			country.Regions.Add(new Region("08", "Santa Cruz"));
			country.Regions.Add(new Region("09", "Tarija"));
			countryList.Add(country);

			// Bosnia and Herzegovina
			country = new Country("Bosnia and Herzegovina", "BA");
			country.Regions.Add(new Region("01", "Federation of Bosnia and Herzegovina"));
			country.Regions.Add(new Region("02", "Republika Srpska"));
			countryList.Add(country);

			// Botswana
			country = new Country("Botswana", "BW");
			country.Regions.Add(new Region("01", "Central"));
			country.Regions.Add(new Region("03", "Ghanzi"));
			country.Regions.Add(new Region("04", "Kgalagadi"));
			country.Regions.Add(new Region("05", "Kgatleng"));
			country.Regions.Add(new Region("06", "Kweneng"));
			country.Regions.Add(new Region("08", "North-East"));
			country.Regions.Add(new Region("09", "South-East"));
			country.Regions.Add(new Region("10", "Southern"));
			country.Regions.Add(new Region("11", "North-West"));
			countryList.Add(country);

			// Bouvet Island -------------------------------------------------------------------
			//country = new Country("Bouvet Island", "BV");
			//countryList.Add(country);

			// Brazil
			country = new Country("Brazil", "BR");
			country.Regions.Add(new Region("01", "Acre"));
			country.Regions.Add(new Region("02", "Alagoas"));
			country.Regions.Add(new Region("03", "Amapa"));
			country.Regions.Add(new Region("04", "Amazonas"));
			country.Regions.Add(new Region("05", "Bahia"));
			country.Regions.Add(new Region("06", "Ceara"));
			country.Regions.Add(new Region("07", "Distrito Federal"));
			country.Regions.Add(new Region("08", "Espirito Santo"));
			country.Regions.Add(new Region("11", "Mato Grosso do Sul"));
			country.Regions.Add(new Region("13", "Maranhao"));
			country.Regions.Add(new Region("14", "Mato Grosso"));
			country.Regions.Add(new Region("15", "Minas Gerais"));
			country.Regions.Add(new Region("16", "Para"));
			country.Regions.Add(new Region("17", "Paraiba"));
			country.Regions.Add(new Region("18", "Parana"));
			country.Regions.Add(new Region("20", "Piaui"));
			country.Regions.Add(new Region("21", "Rio de Janeiro"));
			country.Regions.Add(new Region("22", "Rio Grande do Norte"));
			country.Regions.Add(new Region("23", "Rio Grande do Sul"));
			country.Regions.Add(new Region("24", "Rondonia"));
			country.Regions.Add(new Region("25", "Roraima"));
			country.Regions.Add(new Region("26", "Santa Catarina"));
			country.Regions.Add(new Region("27", "Sao Paulo"));
			country.Regions.Add(new Region("28", "Sergipe"));
			country.Regions.Add(new Region("29", "Goias"));
			country.Regions.Add(new Region("30", "Pernambuco"));
			country.Regions.Add(new Region("31", "Tocantins"));
			countryList.Add(country);

			// British Indian Ocean Territory -------------------------------------------------------------------
			//country = new Country("British Indian Ocean Territory", "IO");
			//countryList.Add(country);

			// Brunei Darussalam
			country = new Country("Brunei Darussalam", "BN");
			country.Regions.Add(new Region("07", "Alibori"));
			country.Regions.Add(new Region("08", "Belait"));
			country.Regions.Add(new Region("09", "Brunei and Muara"));
			country.Regions.Add(new Region("10", "Temburong"));
			country.Regions.Add(new Region("11", "Collines"));
			country.Regions.Add(new Region("12", "Kouffo"));
			country.Regions.Add(new Region("13", "Donga"));
			country.Regions.Add(new Region("14", "Littoral"));
			country.Regions.Add(new Region("15", "Tutong"));
			country.Regions.Add(new Region("16", "Oueme"));
			country.Regions.Add(new Region("17", "Plateau"));
			country.Regions.Add(new Region("18", "Zou"));
			countryList.Add(country);

			// Bulgaria
			country = new Country("Bulgaria", "BG");
			country.Regions.Add(new Region("33", "Mikhaylovgrad"));
			country.Regions.Add(new Region("38", "Blagoevgrad"));
			country.Regions.Add(new Region("39", "Burgas"));
			country.Regions.Add(new Region("40", "Dobrich"));
			country.Regions.Add(new Region("41", "Gabrovo"));
			country.Regions.Add(new Region("42", "Grad Sofiya"));
			country.Regions.Add(new Region("43", "Khaskovo"));
			country.Regions.Add(new Region("44", "Kurdzhali"));
			country.Regions.Add(new Region("45", "Kyustendil"));
			country.Regions.Add(new Region("46", "Lovech"));
			country.Regions.Add(new Region("47", "Montana"));
			country.Regions.Add(new Region("48", "Pazardzhik"));
			country.Regions.Add(new Region("49", "Pernik"));
			country.Regions.Add(new Region("50", "Pleven"));
			country.Regions.Add(new Region("51", "Plovdiv"));
			country.Regions.Add(new Region("52", "Razgrad"));
			country.Regions.Add(new Region("53", "Ruse"));
			country.Regions.Add(new Region("54", "Shumen"));
			country.Regions.Add(new Region("55", "Silistra"));
			country.Regions.Add(new Region("56", "Sliven"));
			country.Regions.Add(new Region("57", "Smolyan"));
			country.Regions.Add(new Region("58", "Sofiya"));
			country.Regions.Add(new Region("59", "Stara Zagora"));
			country.Regions.Add(new Region("60", "Turgovishte"));
			country.Regions.Add(new Region("61", "Varna"));
			country.Regions.Add(new Region("62", "Veliko Turnovo"));
			country.Regions.Add(new Region("63", "Vidin"));
			country.Regions.Add(new Region("64", "Vratsa"));
			country.Regions.Add(new Region("65", "Yambol"));
			countryList.Add(country);

			// Burkina Faso
			country = new Country("Burkina Faso", "BF");
			country.Regions.Add(new Region("15", "Bam"));
			country.Regions.Add(new Region("19", "Boulkiemde"));
			country.Regions.Add(new Region("20", "Ganzourgou"));
			country.Regions.Add(new Region("21", "Gnagna"));
			country.Regions.Add(new Region("28", "Kouritenga"));
			country.Regions.Add(new Region("33", "Oudalan"));
			country.Regions.Add(new Region("34", "Passore"));
			country.Regions.Add(new Region("36", "Sanguie"));
			country.Regions.Add(new Region("40", "Soum"));
			country.Regions.Add(new Region("42", "Tapoa"));
			country.Regions.Add(new Region("44", "Zoundweogo"));
			country.Regions.Add(new Region("45", "Bale"));
			country.Regions.Add(new Region("46", "Banwa"));
			country.Regions.Add(new Region("47", "Bazega"));
			country.Regions.Add(new Region("48", "Bougouriba"));
			country.Regions.Add(new Region("49", "Boulgou"));
			country.Regions.Add(new Region("50", "Gourma"));
			country.Regions.Add(new Region("51", "Houet"));
			country.Regions.Add(new Region("52", "Ioba"));
			country.Regions.Add(new Region("53", "Kadiogo"));
			country.Regions.Add(new Region("54", "Kenedougou"));
			country.Regions.Add(new Region("55", "Komoe"));
			country.Regions.Add(new Region("56", "Komondjari"));
			country.Regions.Add(new Region("57", "Kompienga"));
			country.Regions.Add(new Region("58", "Kossi"));
			country.Regions.Add(new Region("59", "Koulpelogo"));
			country.Regions.Add(new Region("60", "Kourweogo"));
			country.Regions.Add(new Region("61", "Leraba"));
			country.Regions.Add(new Region("62", "Loroum"));
			country.Regions.Add(new Region("63", "Mouhoun"));
			country.Regions.Add(new Region("64", "Namentenga"));
			country.Regions.Add(new Region("65", "Naouri"));
			country.Regions.Add(new Region("66", "Nayala"));
			country.Regions.Add(new Region("67", "Noumbiel"));
			country.Regions.Add(new Region("68", "Oubritenga"));
			country.Regions.Add(new Region("69", "Poni"));
			country.Regions.Add(new Region("70", "Sanmatenga"));
			country.Regions.Add(new Region("71", "Seno"));
			country.Regions.Add(new Region("72", "Sissili"));
			country.Regions.Add(new Region("73", "Sourou"));
			country.Regions.Add(new Region("74", "Tuy"));
			country.Regions.Add(new Region("75", "Yagha"));
			country.Regions.Add(new Region("76", "Yatenga"));
			country.Regions.Add(new Region("77", "Ziro"));
			country.Regions.Add(new Region("78", "Zondoma"));
			countryList.Add(country);

			// Burundi
			country = new Country("Burundi", "BI");
			country.Regions.Add(new Region("02", "Bujumbura"));
			country.Regions.Add(new Region("09", "Bubanza"));
			country.Regions.Add(new Region("10", "Bururi"));
			country.Regions.Add(new Region("11", "Cankuzo"));
			country.Regions.Add(new Region("12", "Cibitoke"));
			country.Regions.Add(new Region("13", "Gitega"));
			country.Regions.Add(new Region("14", "Karuzi"));
			country.Regions.Add(new Region("15", "Kayanza"));
			country.Regions.Add(new Region("16", "Kirundo"));
			country.Regions.Add(new Region("17", "Makamba"));
			country.Regions.Add(new Region("18", "Muyinga"));
			country.Regions.Add(new Region("19", "Ngozi"));
			country.Regions.Add(new Region("20", "Rutana"));
			country.Regions.Add(new Region("21", "Ruyigi"));
			country.Regions.Add(new Region("22", "Muramvya"));
			country.Regions.Add(new Region("23", "Mwaro"));
			countryList.Add(country);

			// Cambodia
			country = new Country("Cambodia", "KH");
			country.Regions.Add(new Region("01", "Batdambang"));
			country.Regions.Add(new Region("02", "Kampong Cham"));
			country.Regions.Add(new Region("03", "Kampong Chhnang"));
			country.Regions.Add(new Region("04", "Kampong Speu"));
			country.Regions.Add(new Region("05", "Kampong Thum"));
			country.Regions.Add(new Region("06", "Kampot"));
			country.Regions.Add(new Region("07", "Kandal"));
			country.Regions.Add(new Region("08", "Koh Kong"));
			country.Regions.Add(new Region("09", "Kracheh"));
			country.Regions.Add(new Region("10", "Mondulkiri"));
			country.Regions.Add(new Region("11", "Phnum Penh"));
			country.Regions.Add(new Region("12", "Pursat"));
			country.Regions.Add(new Region("13", "Preah Vihear"));
			country.Regions.Add(new Region("14", "Prey Veng"));
			country.Regions.Add(new Region("15", "Ratanakiri Kiri"));
			country.Regions.Add(new Region("16", "Siem Reap"));
			country.Regions.Add(new Region("17", "Stung Treng"));
			country.Regions.Add(new Region("18", "Svay Rieng"));
			country.Regions.Add(new Region("19", "Takeo"));
			country.Regions.Add(new Region("25", "Banteay Meanchey"));
			country.Regions.Add(new Region("29", "Batdambang"));
			country.Regions.Add(new Region("30", "Pailin"));
			countryList.Add(country);

			// Cameroon
			country = new Country("Cameroon", "CM");
			country.Regions.Add(new Region("04", "Est"));
			country.Regions.Add(new Region("05", "Littoral"));
			country.Regions.Add(new Region("07", "Nord-Ouest"));
			country.Regions.Add(new Region("08", "Ouest"));
			country.Regions.Add(new Region("09", "Sud-Ouest"));
			country.Regions.Add(new Region("10", "Adamaoua"));
			country.Regions.Add(new Region("11", "Centre"));
			country.Regions.Add(new Region("12", "Extreme-Nord"));
			country.Regions.Add(new Region("13", "Nord"));
			country.Regions.Add(new Region("14", "Sud"));
			countryList.Add(country);

			// Canada
			country = new Country("Canada", "CA");
			country.Regions.Add(new Region("AB", "Alberta"));
			country.Regions.Add(new Region("BC", "British Columbia"));
			country.Regions.Add(new Region("MB", "Manitoba"));
			country.Regions.Add(new Region("NB", "New Brunswick"));
			country.Regions.Add(new Region("NL", "Newfoundland"));
			country.Regions.Add(new Region("NS", "Nova Scotia"));
			country.Regions.Add(new Region("NT", "Northwest Territories"));
			country.Regions.Add(new Region("NU", "Nunavut"));
			country.Regions.Add(new Region("ON", "Ontario"));
			country.Regions.Add(new Region("PE", "Prince Edward Island"));
			country.Regions.Add(new Region("QC", "Quebec"));
			country.Regions.Add(new Region("SK", "Saskatchewan"));
			country.Regions.Add(new Region("YT", "Yukon Territory"));
			countryList.Add(country);

			// Cape Verde
			country = new Country("Cape Verde", "CV");
			country.Regions.Add(new Region("01", "Boa Vista"));
			country.Regions.Add(new Region("02", "Brava"));
			country.Regions.Add(new Region("04", "Maio"));
			country.Regions.Add(new Region("05", "Paul"));
			country.Regions.Add(new Region("07", "Ribeira Grande"));
			country.Regions.Add(new Region("08", "Sal"));
			country.Regions.Add(new Region("10", "Sao Nicolau"));
			country.Regions.Add(new Region("11", "Sao Vicente"));
			country.Regions.Add(new Region("13", "Mosteiros"));
			country.Regions.Add(new Region("14", "Praia"));
			country.Regions.Add(new Region("15", "Santa Catarina"));
			country.Regions.Add(new Region("16", "Santa Cruz"));
			country.Regions.Add(new Region("17", "Sao Domingos"));
			country.Regions.Add(new Region("18", "Sao Filipe"));
			country.Regions.Add(new Region("19", "Sao Miguel"));
			country.Regions.Add(new Region("20", "Tarrafal"));
			countryList.Add(country);

			// Cayman Islands
			country = new Country("Cayman Islands", "KY");
			country.Regions.Add(new Region("01", "Creek"));
			country.Regions.Add(new Region("02", "Eastern"));
			country.Regions.Add(new Region("03", "Midland"));
			country.Regions.Add(new Region("04", "South Town"));
			country.Regions.Add(new Region("05", "Spot Bay"));
			country.Regions.Add(new Region("06", "Stake Bay"));
			country.Regions.Add(new Region("07", "West End"));
			country.Regions.Add(new Region("08", "Western"));
			countryList.Add(country);

			// Central African Republic
			country = new Country("Central African Republic", "CF");
			country.Regions.Add(new Region("01", "Bamingui-Bangoran"));
			country.Regions.Add(new Region("02", "Basse-Kotto"));
			country.Regions.Add(new Region("03", "Haute-Kotto"));
			country.Regions.Add(new Region("04", "Mambere-Kadei"));
			country.Regions.Add(new Region("05", "Haut-Mbomou"));
			country.Regions.Add(new Region("06", "Kemo"));
			country.Regions.Add(new Region("07", "Lobaye"));
			country.Regions.Add(new Region("08", "Mbomou"));
			country.Regions.Add(new Region("09", "Nana-Mambere"));
			country.Regions.Add(new Region("11", "Ouaka"));
			country.Regions.Add(new Region("12", "Ouham"));
			country.Regions.Add(new Region("13", "Ouham-Pende"));
			country.Regions.Add(new Region("14", "Cuvette-Ouest"));
			country.Regions.Add(new Region("15", "Nana-Grebizi"));
			country.Regions.Add(new Region("16", "Sangha-Mbaere"));
			country.Regions.Add(new Region("17", "Ombella-Mpoko"));
			country.Regions.Add(new Region("18", "Bangui"));
			countryList.Add(country);

			// Chad
			country = new Country("Chad", "TD");
			country.Regions.Add(new Region("01", "Batha"));
			country.Regions.Add(new Region("02", "Biltine"));
			country.Regions.Add(new Region("03", "Borkou-Ennedi-Tibesti"));
			country.Regions.Add(new Region("04", "Chari-Baguirmi"));
			country.Regions.Add(new Region("05", "Guera"));
			country.Regions.Add(new Region("06", "Kanem"));
			country.Regions.Add(new Region("07", "Lac"));
			country.Regions.Add(new Region("08", "Logone Occidental"));
			country.Regions.Add(new Region("09", "Logone Oriental"));
			country.Regions.Add(new Region("10", "Mayo-Kebbi"));
			country.Regions.Add(new Region("11", "Moyen-Chari"));
			country.Regions.Add(new Region("12", "Ouaddai"));
			country.Regions.Add(new Region("13", "Salamat"));
			country.Regions.Add(new Region("14", "Tandjile"));
			countryList.Add(country);

			// Chile
			country = new Country("Chile", "CL");
			country.Regions.Add(new Region("01", "Valparaiso"));
			country.Regions.Add(new Region("02", "Aisen del General Carlos Ibanez del Campo"));
			country.Regions.Add(new Region("03", "Antofagasta"));
			country.Regions.Add(new Region("04", "Araucania"));
			country.Regions.Add(new Region("05", "Atacama"));
			country.Regions.Add(new Region("06", "Bio-Bio"));
			country.Regions.Add(new Region("07", "Coquimbo"));
			country.Regions.Add(new Region("08", "Libertador General Bernardo O'Higgins"));
			country.Regions.Add(new Region("09", "Los Lagos"));
			country.Regions.Add(new Region("10", "Magallanes y de la Antartica Chilena"));
			country.Regions.Add(new Region("11", "Maule"));
			country.Regions.Add(new Region("12", "Region Metropolitana"));
			country.Regions.Add(new Region("13", "Tarapaca"));
			country.Regions.Add(new Region("14", "Los Lagos"));
			country.Regions.Add(new Region("15", "Tarapaca"));
			country.Regions.Add(new Region("16", "Arica y Parinacota"));
			country.Regions.Add(new Region("17", "Los Rios"));
			countryList.Add(country);

			// China
			country = new Country("China", "CN");
			country.Regions.Add(new Region("01", "Anhui"));
			country.Regions.Add(new Region("02", "Zhejiang"));
			country.Regions.Add(new Region("03", "Jiangxi"));
			country.Regions.Add(new Region("04", "Jiangsu"));
			country.Regions.Add(new Region("05", "Jilin"));
			country.Regions.Add(new Region("06", "Qinghai"));
			country.Regions.Add(new Region("07", "Fujian"));
			country.Regions.Add(new Region("08", "Heilongjiang"));
			country.Regions.Add(new Region("09", "Henan"));
			country.Regions.Add(new Region("10", "Hebei"));
			country.Regions.Add(new Region("11", "Hunan"));
			country.Regions.Add(new Region("12", "Hubei"));
			country.Regions.Add(new Region("13", "Xinjiang"));
			country.Regions.Add(new Region("14", "Xizang"));
			country.Regions.Add(new Region("15", "Gansu"));
			country.Regions.Add(new Region("16", "Guangxi"));
			country.Regions.Add(new Region("18", "Guizhou"));
			country.Regions.Add(new Region("19", "Liaoning"));
			country.Regions.Add(new Region("20", "Nei Mongol"));
			country.Regions.Add(new Region("21", "Ningxia"));
			country.Regions.Add(new Region("22", "Beijing"));
			country.Regions.Add(new Region("23", "Shanghai"));
			country.Regions.Add(new Region("24", "Shanxi"));
			country.Regions.Add(new Region("25", "Shandong"));
			country.Regions.Add(new Region("26", "Shaanxi"));
			country.Regions.Add(new Region("28", "Tianjin"));
			country.Regions.Add(new Region("29", "Yunnan"));
			country.Regions.Add(new Region("30", "Guangdong"));
			country.Regions.Add(new Region("31", "Hainan"));
			country.Regions.Add(new Region("32", "Sichuan"));
			country.Regions.Add(new Region("33", "Chongqing"));
			countryList.Add(country);

			// Christmans Island -------------------------------------------------------------------
			country = new Country("Christmans Island", "CX");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Cocos (Keeling Islands) -------------------------------------------------------------------
			//country = new Country("Cocos (Keeling Islands)", "CC");
			//countryList.Add(country);

			// Colombia
			country = new Country("Colombia", "CO");
			country.Regions.Add(new Region("01", "Amazonas"));
			country.Regions.Add(new Region("02", "Antioquia"));
			country.Regions.Add(new Region("03", "Arauca"));
			country.Regions.Add(new Region("04", "Atlantico"));
			country.Regions.Add(new Region("08", "Caqueta"));
			country.Regions.Add(new Region("09", "Cauca"));
			country.Regions.Add(new Region("10", "Cesar"));
			country.Regions.Add(new Region("11", "Choco"));
			country.Regions.Add(new Region("12", "Cordoba"));
			country.Regions.Add(new Region("14", "Guaviare"));
			country.Regions.Add(new Region("15", "Guainia"));
			country.Regions.Add(new Region("16", "Huila"));
			country.Regions.Add(new Region("17", "La Guajira"));
			country.Regions.Add(new Region("19", "Meta"));
			country.Regions.Add(new Region("20", "Narino"));
			country.Regions.Add(new Region("21", "Norte de Santander"));
			country.Regions.Add(new Region("22", "Putumayo"));
			country.Regions.Add(new Region("23", "Quindio"));
			country.Regions.Add(new Region("24", "Risaralda"));
			country.Regions.Add(new Region("25", "San Andres y Providencia"));
			country.Regions.Add(new Region("26", "Santander"));
			country.Regions.Add(new Region("27", "Sucre"));
			country.Regions.Add(new Region("28", "Tolima"));
			country.Regions.Add(new Region("29", "Valle del Cauca"));
			country.Regions.Add(new Region("30", "Vaupes"));
			country.Regions.Add(new Region("31", "Vichada"));
			country.Regions.Add(new Region("32", "Casanare"));
			country.Regions.Add(new Region("33", "Cundinamarca"));
			country.Regions.Add(new Region("34", "Distrito Especial"));
			country.Regions.Add(new Region("35", "Bolivar"));
			country.Regions.Add(new Region("36", "Boyaca"));
			country.Regions.Add(new Region("37", "Caldas"));
			country.Regions.Add(new Region("38", "Magdalena"));
			countryList.Add(country);

			// Comoros
			country = new Country("Comoros", "KM");
			country.Regions.Add(new Region("01", "Anjouan"));
			country.Regions.Add(new Region("02", "Grande Comore"));
			country.Regions.Add(new Region("03", "Moheli"));
			countryList.Add(country);

			// Congo
			country = new Country("Congo", "CG");
			country.Regions.Add(new Region("01", "Bouenza"));
			country.Regions.Add(new Region("04", "Kouilou"));
			country.Regions.Add(new Region("05", "Lekoumou"));
			country.Regions.Add(new Region("06", "Likouala"));
			country.Regions.Add(new Region("07", "Niari"));
			country.Regions.Add(new Region("08", "Plateaux"));
			country.Regions.Add(new Region("10", "Sangha"));
			country.Regions.Add(new Region("11", "Pool"));
			country.Regions.Add(new Region("12", "Brazzaville"));
			country.Regions.Add(new Region("13", "Cuvette"));
			country.Regions.Add(new Region("14", "Cuvette-Ouest"));
			countryList.Add(country);

			// Cook Islands -------------------------------------------------------------------
			country = new Country("Cook Islands", "CK");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Costa Rica
			country = new Country("Costa Rica", "CR");
			country.Regions.Add(new Region("01", "Alajuela"));
			country.Regions.Add(new Region("02", "Cartago"));
			country.Regions.Add(new Region("03", "Guanacaste"));
			country.Regions.Add(new Region("04", "Heredia"));
			country.Regions.Add(new Region("06", "Limon"));
			country.Regions.Add(new Region("07", "Puntarenas"));
			country.Regions.Add(new Region("08", "San Jose"));
			countryList.Add(country);

			// Cote D'Ivoire (Ivory Coast)
			country = new Country("Cote D'Ivoire (Ivory Coast)", "CI");
			country.Regions.Add(new Region("74", "Agneby"));
			country.Regions.Add(new Region("75", "Bafing"));
			country.Regions.Add(new Region("76", "Bas-Sassandra"));
			country.Regions.Add(new Region("77", "Denguele"));
			country.Regions.Add(new Region("78", "Dix-Huit Montagnes"));
			country.Regions.Add(new Region("79", "Fromager"));
			country.Regions.Add(new Region("80", "Haut-Sassandra"));
			country.Regions.Add(new Region("81", "Lacs"));
			country.Regions.Add(new Region("82", "Lagunes"));
			country.Regions.Add(new Region("83", "Marahoue"));
			country.Regions.Add(new Region("84", "Moyen-Cavally"));
			country.Regions.Add(new Region("85", "Moyen-Comoe"));
			country.Regions.Add(new Region("86", "N'zi-Comoe"));
			country.Regions.Add(new Region("87", "Savanes"));
			country.Regions.Add(new Region("88", "Sud-Bandama"));
			country.Regions.Add(new Region("89", "Sud-Comoe"));
			country.Regions.Add(new Region("90", "Vallee du Bandama"));
			country.Regions.Add(new Region("91", "Worodougou"));
			country.Regions.Add(new Region("92", "Zanzan"));
			countryList.Add(country);

			// Croatia (Hrvatska)
			country = new Country("Croatia (Hrvatska)", "HR");
			country.Regions.Add(new Region("01", "Bjelovarsko-Bilogorska"));
			country.Regions.Add(new Region("02", "Brodsko-Posavska"));
			country.Regions.Add(new Region("03", "Dubrovacko-Neretvanska"));
			country.Regions.Add(new Region("04", "Istarska"));
			country.Regions.Add(new Region("05", "Karlovacka"));
			country.Regions.Add(new Region("06", "Koprivnicko-Krizevacka"));
			country.Regions.Add(new Region("07", "Krapinsko-Zagorska"));
			country.Regions.Add(new Region("08", "Licko-Senjska"));
			country.Regions.Add(new Region("09", "Medimurska"));
			country.Regions.Add(new Region("10", "Osjecko-Baranjska"));
			country.Regions.Add(new Region("11", "Pozesko-Slavonska"));
			country.Regions.Add(new Region("12", "Primorsko-Goranska"));
			country.Regions.Add(new Region("13", "Sibensko-Kninska"));
			country.Regions.Add(new Region("14", "Sisacko-Moslavacka"));
			country.Regions.Add(new Region("15", "Splitsko-Dalmatinska"));
			country.Regions.Add(new Region("16", "Varazdinska"));
			country.Regions.Add(new Region("17", "Viroviticko-Podravska"));
			country.Regions.Add(new Region("18", "Vukovarsko-Srijemska"));
			country.Regions.Add(new Region("19", "Zadarska"));
			country.Regions.Add(new Region("20", "Zagrebacka"));
			country.Regions.Add(new Region("21", "Grad Zagreb"));
			countryList.Add(country);

			// Cuba
			country = new Country("Cuba", "CU");
			country.Regions.Add(new Region("01", "Pinar del Rio"));
			country.Regions.Add(new Region("02", "Ciudad de la Habana"));
			country.Regions.Add(new Region("03", "Matanzas"));
			country.Regions.Add(new Region("04", "Isla de la Juventud"));
			country.Regions.Add(new Region("05", "Camaguey"));
			country.Regions.Add(new Region("07", "Ciego de Avila"));
			country.Regions.Add(new Region("08", "Cienfuegos"));
			country.Regions.Add(new Region("09", "Granma"));
			country.Regions.Add(new Region("10", "Guantanamo"));
			country.Regions.Add(new Region("11", "La Habana"));
			country.Regions.Add(new Region("12", "Holguin"));
			country.Regions.Add(new Region("13", "Las Tunas"));
			country.Regions.Add(new Region("14", "Sancti Spiritus"));
			country.Regions.Add(new Region("15", "Santiago de Cuba"));
			country.Regions.Add(new Region("16", "Villa Clara"));
			countryList.Add(country);

			// Cyprus
			country = new Country("Cyprus", "CY");
			country.Regions.Add(new Region("01", "Famagusta"));
			country.Regions.Add(new Region("02", "Kyrenia"));
			country.Regions.Add(new Region("03", "Larnaca"));
			country.Regions.Add(new Region("04", "Nicosia"));
			country.Regions.Add(new Region("05", "Limassol"));
			country.Regions.Add(new Region("06", "Paphos"));
			countryList.Add(country);

			// Czech Republic
			country = new Country("Czech Republic", "CZ");
			country.Regions.Add(new Region("52", "Hlavni mesto Praha"));
			country.Regions.Add(new Region("78", "Jihomoravsky kraj"));
			country.Regions.Add(new Region("79", "Jihocesky kraj"));
			country.Regions.Add(new Region("80", "Vysocina"));
			country.Regions.Add(new Region("81", "Karlovarsky kraj"));
			country.Regions.Add(new Region("82", "Kralovehradecky kraj"));
			country.Regions.Add(new Region("83", "Liberecky kraj"));
			country.Regions.Add(new Region("84", "Olomoucky kraj"));
			country.Regions.Add(new Region("85", "Moravskoslezsky kraj"));
			country.Regions.Add(new Region("86", "Pardubicky kraj"));
			country.Regions.Add(new Region("87", "Plzensky kraj"));
			country.Regions.Add(new Region("88", "Stredocesky kraj"));
			country.Regions.Add(new Region("89", "Ustecky kraj"));
			country.Regions.Add(new Region("90", "Zlinsky kraj"));
			countryList.Add(country);

			// Democratic Repulic of the Congo
			country = new Country("Democratic Repulic of the Congo", "CD");
			country.Regions.Add(new Region("01", "Bandundu"));
			country.Regions.Add(new Region("02", "Equateur"));
			country.Regions.Add(new Region("04", "Kasai-Oriental"));
			country.Regions.Add(new Region("05", "Katanga"));
			country.Regions.Add(new Region("06", "Kinshasa"));
			country.Regions.Add(new Region("08", "Bas-Congo"));
			country.Regions.Add(new Region("09", "Orientale"));
			country.Regions.Add(new Region("10", "Maniema"));
			country.Regions.Add(new Region("11", "Nord-Kivu"));
			country.Regions.Add(new Region("12", "Sud-Kivu"));
			countryList.Add(country);

			// Denmark
			country = new Country("Denmark", "DK");
			country.Regions.Add(new Region("17", "Hovedstaden"));
			country.Regions.Add(new Region("18", "Midtjylland"));
			country.Regions.Add(new Region("19", "Nordjylland"));
			country.Regions.Add(new Region("20", "Sjelland"));
			country.Regions.Add(new Region("21", "Syddanmark"));
			countryList.Add(country);

			// Djibouti
			country = new Country("Djibouti", "DJ");
			country.Regions.Add(new Region("01", "Ali Sabieh"));
			country.Regions.Add(new Region("04", "Obock"));
			country.Regions.Add(new Region("05", "Tadjoura"));
			country.Regions.Add(new Region("06", "Dikhil"));
			country.Regions.Add(new Region("07", "Djibouti"));
			country.Regions.Add(new Region("08", "Arta"));
			countryList.Add(country);

			// Dominica
			country = new Country("Dominica", "DM");
			country.Regions.Add(new Region("02", "Saint Andrew"));
			country.Regions.Add(new Region("03", "Saint David"));
			country.Regions.Add(new Region("04", "Saint George"));
			country.Regions.Add(new Region("05", "Saint John"));
			country.Regions.Add(new Region("06", "Saint Joseph"));
			country.Regions.Add(new Region("07", "Saint Luke"));
			country.Regions.Add(new Region("08", "Saint Mark"));
			country.Regions.Add(new Region("09", "Saint Patrick"));
			country.Regions.Add(new Region("10", "Saint Paul"));
			country.Regions.Add(new Region("11", "Saint Peter"));
			countryList.Add(country);

			// Dominican Republic
			country = new Country("Dominican Republic", "DO");
			country.Regions.Add(new Region("01", "Azua"));
			country.Regions.Add(new Region("02", "Baoruco"));
			country.Regions.Add(new Region("03", "Barahona"));
			country.Regions.Add(new Region("04", "Dajabon"));
			country.Regions.Add(new Region("05", "Distrito Nacional"));
			country.Regions.Add(new Region("06", "Duarte"));
			country.Regions.Add(new Region("08", "Espaillat"));
			country.Regions.Add(new Region("09", "Independencia"));
			country.Regions.Add(new Region("10", "La Altagracia"));
			country.Regions.Add(new Region("11", "Elias Pina"));
			country.Regions.Add(new Region("12", "La Romana"));
			country.Regions.Add(new Region("14", "Maria Trinidad Sanchez"));
			country.Regions.Add(new Region("15", "Monte Cristi"));
			country.Regions.Add(new Region("16", "Pedernales"));
			country.Regions.Add(new Region("17", "Peravia"));
			country.Regions.Add(new Region("18", "Puerto Plata"));
			country.Regions.Add(new Region("19", "Salcedo"));
			country.Regions.Add(new Region("20", "Samana"));
			country.Regions.Add(new Region("21", "Sanchez Ramirez"));
			country.Regions.Add(new Region("23", "San Juan"));
			country.Regions.Add(new Region("24", "San Pedro De Macoris"));
			country.Regions.Add(new Region("25", "Santiago"));
			country.Regions.Add(new Region("26", "Santiago Rodriguez"));
			country.Regions.Add(new Region("27", "Valverde"));
			country.Regions.Add(new Region("28", "El Seibo"));
			country.Regions.Add(new Region("29", "Hato Mayor"));
			country.Regions.Add(new Region("30", "La Vega"));
			country.Regions.Add(new Region("31", "Monsenor Nouel"));
			country.Regions.Add(new Region("32", "Monte Plata"));
			country.Regions.Add(new Region("33", "San Cristobal"));
			country.Regions.Add(new Region("34", "Distrito Nacional"));
			country.Regions.Add(new Region("35", "Peravia"));
			country.Regions.Add(new Region("36", "San Jose de Ocoa"));
			country.Regions.Add(new Region("37", "Santo Domingo"));
			countryList.Add(country);

			// Ecuador
			country = new Country("Ecuador", "EC");
			country.Regions.Add(new Region("01", "Galapagos"));
			country.Regions.Add(new Region("02", "Azuay"));
			country.Regions.Add(new Region("03", "Bolivar"));
			country.Regions.Add(new Region("04", "Canar"));
			country.Regions.Add(new Region("05", "Carchi"));
			country.Regions.Add(new Region("06", "Chimborazo"));
			country.Regions.Add(new Region("07", "Cotopaxi"));
			country.Regions.Add(new Region("08", "El Oro"));
			country.Regions.Add(new Region("09", "Esmeraldas"));
			country.Regions.Add(new Region("10", "Guayas"));
			country.Regions.Add(new Region("11", "Imbabura"));
			country.Regions.Add(new Region("12", "Loja"));
			country.Regions.Add(new Region("13", "Los Rios"));
			country.Regions.Add(new Region("14", "Manabi"));
			country.Regions.Add(new Region("15", "Morona-Santiago"));
			country.Regions.Add(new Region("17", "Pastaza"));
			country.Regions.Add(new Region("18", "Pichincha"));
			country.Regions.Add(new Region("19", "Tungurahua"));
			country.Regions.Add(new Region("20", "Zamora-Chinchipe"));
			country.Regions.Add(new Region("22", "Sucumbios"));
			country.Regions.Add(new Region("23", "Napo"));
			country.Regions.Add(new Region("24", "Orellana"));
			countryList.Add(country);

			// Egypt
			country = new Country("Egypt", "EG");
			country.Regions.Add(new Region("01", "Ad Daqahliyah"));
			country.Regions.Add(new Region("02", "Al Bahr al Ahmar"));
			country.Regions.Add(new Region("03", "Al Buhayrah"));
			country.Regions.Add(new Region("04", "Al Fayyum"));
			country.Regions.Add(new Region("05", "Al Gharbiyah"));
			country.Regions.Add(new Region("06", "Al Iskandariyah"));
			country.Regions.Add(new Region("07", "Al Isma'iliyah"));
			country.Regions.Add(new Region("08", "Al Jizah"));
			country.Regions.Add(new Region("09", "Al Minufiyah"));
			country.Regions.Add(new Region("10", "Al Minya"));
			country.Regions.Add(new Region("11", "Al Qahirah"));
			country.Regions.Add(new Region("12", "Al Qalyubiyah"));
			country.Regions.Add(new Region("13", "Al Wadi al Jadid"));
			country.Regions.Add(new Region("14", "Ash Sharqiyah"));
			country.Regions.Add(new Region("15", "As Suways"));
			country.Regions.Add(new Region("16", "Aswan"));
			country.Regions.Add(new Region("17", "Asyut"));
			country.Regions.Add(new Region("18", "Bani Suwayf"));
			country.Regions.Add(new Region("19", "Bur Sa'id"));
			country.Regions.Add(new Region("20", "Dumyat"));
			country.Regions.Add(new Region("21", "Kafr ash Shaykh"));
			country.Regions.Add(new Region("22", "Matruh"));
			country.Regions.Add(new Region("23", "Qina"));
			country.Regions.Add(new Region("24", "Suhaj"));
			country.Regions.Add(new Region("26", "Janub Sina'"));
			country.Regions.Add(new Region("27", "Shamal Sina'"));
			countryList.Add(country);

			// El Salvador
			country = new Country("El Salvador", "SV");
			country.Regions.Add(new Region("01", "Ahuachapan"));
			country.Regions.Add(new Region("02", "Cabanas"));
			country.Regions.Add(new Region("03", "Chalatenango"));
			country.Regions.Add(new Region("04", "Cuscatlan"));
			country.Regions.Add(new Region("05", "La Libertad"));
			country.Regions.Add(new Region("06", "La Paz"));
			country.Regions.Add(new Region("07", "La Union"));
			country.Regions.Add(new Region("08", "Morazan"));
			country.Regions.Add(new Region("09", "San Miguel"));
			country.Regions.Add(new Region("10", "San Salvador"));
			country.Regions.Add(new Region("11", "Santa Ana"));
			country.Regions.Add(new Region("12", "San Vicente"));
			country.Regions.Add(new Region("13", "Sonsonate"));
			country.Regions.Add(new Region("14", "Usulutan"));
			countryList.Add(country);

			// Equatorial Guinea
			country = new Country("Equatorial Guinea", "GQ");
			country.Regions.Add(new Region("03", "Annobon"));
			country.Regions.Add(new Region("04", "Bioko Norte"));
			country.Regions.Add(new Region("05", "Bioko Sur"));
			country.Regions.Add(new Region("06", "Centro Sur"));
			country.Regions.Add(new Region("07", "Kie-Ntem"));
			country.Regions.Add(new Region("08", "Litoral"));
			country.Regions.Add(new Region("09", "Wele-Nzas"));
			countryList.Add(country);

			// Eritrea
			country = new Country("Eritrea", "ER");
			country.Regions.Add(new Region("01", "Anseba"));
			country.Regions.Add(new Region("02", "Debub"));
			country.Regions.Add(new Region("03", "Debubawi K'eyih Bahri"));
			country.Regions.Add(new Region("04", "Gash Barka"));
			country.Regions.Add(new Region("05", "Ma'akel"));
			country.Regions.Add(new Region("06", "Semenawi K'eyih Bahri"));
			countryList.Add(country);

			// Estonia
			country = new Country("Estonia", "EE");
			country.Regions.Add(new Region("01", "Harjumaa"));
			country.Regions.Add(new Region("02", "Hiiumaa"));
			country.Regions.Add(new Region("03", "Ida-Virumaa"));
			country.Regions.Add(new Region("04", "Jarvamaa"));
			country.Regions.Add(new Region("05", "Jogevamaa"));
			country.Regions.Add(new Region("06", "Kohtla-Jarve"));
			country.Regions.Add(new Region("07", "Laanemaa"));
			country.Regions.Add(new Region("08", "Laane-Virumaa"));
			country.Regions.Add(new Region("09", "Narva"));
			country.Regions.Add(new Region("10", "Parnu"));
			country.Regions.Add(new Region("11", "Parnumaa"));
			country.Regions.Add(new Region("12", "Polvamaa"));
			country.Regions.Add(new Region("13", "Raplamaa"));
			country.Regions.Add(new Region("14", "Saaremaa"));
			country.Regions.Add(new Region("15", "Sillamae"));
			country.Regions.Add(new Region("16", "Tallinn"));
			country.Regions.Add(new Region("17", "Tartu"));
			country.Regions.Add(new Region("18", "Tartumaa"));
			country.Regions.Add(new Region("19", "Valgamaa"));
			country.Regions.Add(new Region("20", "Viljandimaa"));
			country.Regions.Add(new Region("21", "Vorumaa"));
			countryList.Add(country);

			// Ethiopia
			country = new Country("Ethiopia", "ET");
			country.Regions.Add(new Region("44", "Adis Abeba"));
			country.Regions.Add(new Region("45", "Afar"));
			country.Regions.Add(new Region("46", "Amara"));
			country.Regions.Add(new Region("47", "Binshangul Gumuz"));
			country.Regions.Add(new Region("48", "Dire Dawa"));
			country.Regions.Add(new Region("49", "Gambela Hizboch"));
			country.Regions.Add(new Region("50", "Hareri Hizb"));
			country.Regions.Add(new Region("51", "Oromiya"));
			country.Regions.Add(new Region("52", "Sumale"));
			country.Regions.Add(new Region("53", "Tigray"));
			country.Regions.Add(new Region("54", "YeDebub Biheroch Bihereseboch na Hizboch"));
			countryList.Add(country);

			// Falkland Islands (Malvinas) -------------------------------------------------------------------
			country = new Country("Falkland Islands (Malvinas)", "FK");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Faroe Islands -------------------------------------------------------------------
			country = new Country("Faroe Islands", "FO");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Fiji
			country = new Country("Fiji", "FJ");
			country.Regions.Add(new Region("01", "Central"));
			country.Regions.Add(new Region("02", "Eastern"));
			country.Regions.Add(new Region("03", "Northern"));
			country.Regions.Add(new Region("04", "Rotuma"));
			country.Regions.Add(new Region("05", "Western"));
			countryList.Add(country);

			// Finland
			country = new Country("Finland", "FI");
			country.Regions.Add(new Region("01", "Aland"));
			country.Regions.Add(new Region("06", "Lapland"));
			country.Regions.Add(new Region("08", "Oulu"));
			country.Regions.Add(new Region("13", "Southern Finland"));
			country.Regions.Add(new Region("14", "Eastern Finland"));
			country.Regions.Add(new Region("15", "Western Finland"));
			countryList.Add(country);

			// France
			country = new Country("France", "FR");
			country.Regions.Add(new Region("97", "Aquitaine"));
			country.Regions.Add(new Region("98", "Auvergne"));
			country.Regions.Add(new Region("99", "Basse-Normandie"));
			country.Regions.Add(new Region("A1", "Bourgogne"));
			country.Regions.Add(new Region("A2", "Bretagne"));
			country.Regions.Add(new Region("A3", "Centre"));
			country.Regions.Add(new Region("A4", "Champagne-Ardenne"));
			country.Regions.Add(new Region("A5", "Corse"));
			country.Regions.Add(new Region("A6", "Franche-Comte"));
			country.Regions.Add(new Region("A7", "Haute-Normandie"));
			country.Regions.Add(new Region("A8", "Ile-de-France"));
			country.Regions.Add(new Region("A9", "Languedoc-Roussillon"));
			country.Regions.Add(new Region("B1", "Limousin"));
			country.Regions.Add(new Region("B2", "Lorraine"));
			country.Regions.Add(new Region("B3", "Midi-Pyrenees"));
			country.Regions.Add(new Region("B4", "Nord-Pas-de-Calais"));
			country.Regions.Add(new Region("B5", "Pays de la Loire"));
			country.Regions.Add(new Region("B6", "Picardie"));
			country.Regions.Add(new Region("B7", "Poitou-Charentes"));
			country.Regions.Add(new Region("B8", "Provence-Alpes-Cote d'Azur"));
			country.Regions.Add(new Region("B9", "Rhone-Alpes"));
			country.Regions.Add(new Region("C1", "Alsace"));
			countryList.Add(country);

			// Gabon
			country = new Country("Gabon", "GA");
			country.Regions.Add(new Region("01", "Estuaire"));
			country.Regions.Add(new Region("02", "Haut-Ogooue"));
			country.Regions.Add(new Region("03", "Moyen-Ogooue"));
			country.Regions.Add(new Region("04", "Ngounie"));
			country.Regions.Add(new Region("05", "Nyanga"));
			country.Regions.Add(new Region("06", "Ogooue-Ivindo"));
			country.Regions.Add(new Region("07", "Ogooue-Lolo"));
			country.Regions.Add(new Region("08", "Ogooue-Maritime"));
			country.Regions.Add(new Region("09", "Woleu-Ntem"));
			countryList.Add(country);

			// Gambia
			country = new Country("Gambia", "GM");
			country.Regions.Add(new Region("01", "Banjul"));
			country.Regions.Add(new Region("02", "Lower River"));
			country.Regions.Add(new Region("03", "Central River"));
			country.Regions.Add(new Region("04", "Upper River"));
			country.Regions.Add(new Region("05", "Western"));
			country.Regions.Add(new Region("07", "North Bank"));
			countryList.Add(country);

			// Georgia
			country = new Country("Georgia", "GE");
			country.Regions.Add(new Region("01", "Abashis Raioni"));
			country.Regions.Add(new Region("02", "Abkhazia"));
			country.Regions.Add(new Region("03", "Adigenis Raioni"));
			country.Regions.Add(new Region("04", "Ajaria"));
			country.Regions.Add(new Region("05", "Akhalgoris Raioni"));
			country.Regions.Add(new Region("06", "Akhalk'alak'is Raioni"));
			country.Regions.Add(new Region("07", "Akhalts'ikhis Raioni"));
			country.Regions.Add(new Region("08", "Akhmetis Raioni"));
			country.Regions.Add(new Region("09", "Ambrolauris Raioni"));
			country.Regions.Add(new Region("10", "Aspindzis Raioni"));
			country.Regions.Add(new Region("11", "Baghdat'is Raioni"));
			country.Regions.Add(new Region("12", "Bolnisis Raioni"));
			country.Regions.Add(new Region("13", "Borjomis Raioni"));
			country.Regions.Add(new Region("14", "Chiat'ura"));
			country.Regions.Add(new Region("15", "Ch'khorotsqus Raioni"));
			country.Regions.Add(new Region("16", "Ch'okhatauris Raioni"));
			country.Regions.Add(new Region("17", "Dedop'listsqaros Raioni"));
			country.Regions.Add(new Region("18", "Dmanisis Raioni"));
			country.Regions.Add(new Region("19", "Dushet'is Raioni"));
			country.Regions.Add(new Region("20", "Gardabanis Raioni"));
			country.Regions.Add(new Region("21", "Gori"));
			country.Regions.Add(new Region("22", "Goris Raioni"));
			country.Regions.Add(new Region("23", "Gurjaanis Raioni"));
			country.Regions.Add(new Region("24", "Javis Raioni"));
			country.Regions.Add(new Region("25", "K'arelis Raioni"));
			country.Regions.Add(new Region("26", "Kaspis Raioni"));
			country.Regions.Add(new Region("27", "Kharagaulis Raioni"));
			country.Regions.Add(new Region("28", "Khashuris Raioni"));
			country.Regions.Add(new Region("29", "Khobis Raioni"));
			country.Regions.Add(new Region("30", "Khonis Raioni"));
			country.Regions.Add(new Region("31", "K'ut'aisi"));
			country.Regions.Add(new Region("32", "Lagodekhis Raioni"));
			country.Regions.Add(new Region("33", "Lanch'khut'is Raioni"));
			country.Regions.Add(new Region("34", "Lentekhis Raioni"));
			country.Regions.Add(new Region("35", "Marneulis Raioni"));
			country.Regions.Add(new Region("36", "Martvilis Raioni"));
			country.Regions.Add(new Region("37", "Mestiis Raioni"));
			country.Regions.Add(new Region("38", "Mts'khet'is Raioni"));
			country.Regions.Add(new Region("39", "Ninotsmindis Raioni"));
			country.Regions.Add(new Region("40", "Onis Raioni"));
			country.Regions.Add(new Region("41", "Ozurget'is Raioni"));
			country.Regions.Add(new Region("42", "P'ot'i"));
			country.Regions.Add(new Region("43", "Qazbegis Raioni"));
			country.Regions.Add(new Region("44", "Qvarlis Raioni"));
			country.Regions.Add(new Region("45", "Rust'avi"));
			country.Regions.Add(new Region("46", "Sach'kheris Raioni"));
			country.Regions.Add(new Region("47", "Sagarejos Raioni"));
			country.Regions.Add(new Region("48", "Samtrediis Raioni"));
			country.Regions.Add(new Region("49", "Senakis Raioni"));
			country.Regions.Add(new Region("50", "Sighnaghis Raioni"));
			country.Regions.Add(new Region("51", "T'bilisi"));
			country.Regions.Add(new Region("52", "T'elavis Raioni"));
			country.Regions.Add(new Region("53", "T'erjolis Raioni"));
			country.Regions.Add(new Region("54", "T'et'ritsqaros Raioni"));
			country.Regions.Add(new Region("55", "T'ianet'is Raioni"));
			country.Regions.Add(new Region("56", "Tqibuli"));
			country.Regions.Add(new Region("57", "Ts'ageris Raioni"));
			country.Regions.Add(new Region("58", "Tsalenjikhis Raioni"));
			country.Regions.Add(new Region("59", "Tsalkis Raioni"));
			country.Regions.Add(new Region("60", "Tsqaltubo"));
			country.Regions.Add(new Region("61", "Vanis Raioni"));
			country.Regions.Add(new Region("62", "Zestap'onis Raioni"));
			country.Regions.Add(new Region("63", "Zugdidi"));
			country.Regions.Add(new Region("64", "Zugdidis Raioni"));
			countryList.Add(country);

			// Germany
			country = new Country("Germany", "DE");
			country.Regions.Add(new Region("01", "Baden-Wurttemberg"));
			country.Regions.Add(new Region("02", "Bayern"));
			country.Regions.Add(new Region("03", "Bremen"));
			country.Regions.Add(new Region("04", "Hamburg"));
			country.Regions.Add(new Region("05", "Hessen"));
			country.Regions.Add(new Region("06", "Niedersachsen"));
			country.Regions.Add(new Region("07", "Nordrhein-Westfalen"));
			country.Regions.Add(new Region("08", "Rheinland-Pfalz"));
			country.Regions.Add(new Region("09", "Saarland"));
			country.Regions.Add(new Region("10", "Schleswig-Holstein"));
			country.Regions.Add(new Region("11", "Brandenburg"));
			country.Regions.Add(new Region("12", "Mecklenburg-Vorpommern"));
			country.Regions.Add(new Region("13", "Sachsen"));
			country.Regions.Add(new Region("14", "Sachsen-Anhalt"));
			country.Regions.Add(new Region("15", "Thuringen"));
			country.Regions.Add(new Region("16", "Berlin"));
			countryList.Add(country);

			// Ghana
			country = new Country("Ghana", "GH");
			country.Regions.Add(new Region("01", "Greater Accra"));
			country.Regions.Add(new Region("02", "Ashanti"));
			country.Regions.Add(new Region("03", "Brong-Ahafo"));
			country.Regions.Add(new Region("04", "Central"));
			country.Regions.Add(new Region("05", "Eastern"));
			country.Regions.Add(new Region("06", "Northern"));
			country.Regions.Add(new Region("08", "Volta"));
			country.Regions.Add(new Region("09", "Western"));
			country.Regions.Add(new Region("10", "Upper East"));
			country.Regions.Add(new Region("11", "Upper West"));
			countryList.Add(country);

			// Gibraltar -------------------------------------------------------------------
			country = new Country("Gibraltar", "GI");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Greece
			country = new Country("Greece", "GR");
			country.Regions.Add(new Region("01", "Evros"));
			country.Regions.Add(new Region("02", "Rodhopi"));
			country.Regions.Add(new Region("03", "Xanthi"));
			country.Regions.Add(new Region("04", "Drama"));
			country.Regions.Add(new Region("05", "Serrai"));
			country.Regions.Add(new Region("06", "Kilkis"));
			country.Regions.Add(new Region("07", "Pella"));
			country.Regions.Add(new Region("08", "Florina"));
			country.Regions.Add(new Region("09", "Kastoria"));
			country.Regions.Add(new Region("10", "Grevena"));
			country.Regions.Add(new Region("11", "Kozani"));
			country.Regions.Add(new Region("12", "Imathia"));
			country.Regions.Add(new Region("13", "Thessaloniki"));
			country.Regions.Add(new Region("14", "Kavala"));
			country.Regions.Add(new Region("15", "Khalkidhiki"));
			country.Regions.Add(new Region("16", "Pieria"));
			country.Regions.Add(new Region("17", "Ioannina"));
			country.Regions.Add(new Region("18", "Thesprotia"));
			country.Regions.Add(new Region("19", "Preveza"));
			country.Regions.Add(new Region("20", "Arta"));
			country.Regions.Add(new Region("21", "Larisa"));
			country.Regions.Add(new Region("22", "Trikala"));
			country.Regions.Add(new Region("23", "Kardhitsa"));
			country.Regions.Add(new Region("24", "Magnisia"));
			country.Regions.Add(new Region("25", "Kerkira"));
			country.Regions.Add(new Region("26", "Levkas"));
			country.Regions.Add(new Region("27", "Kefallinia"));
			country.Regions.Add(new Region("28", "Zakinthos"));
			country.Regions.Add(new Region("29", "Fthiotis"));
			country.Regions.Add(new Region("30", "Evritania"));
			country.Regions.Add(new Region("31", "Aitolia kai Akarnania"));
			country.Regions.Add(new Region("32", "Fokis"));
			country.Regions.Add(new Region("33", "Voiotia"));
			country.Regions.Add(new Region("34", "Evvoia"));
			country.Regions.Add(new Region("35", "Attiki"));
			country.Regions.Add(new Region("36", "Argolis"));
			country.Regions.Add(new Region("37", "Korinthia"));
			country.Regions.Add(new Region("38", "Akhaia"));
			country.Regions.Add(new Region("39", "Ilia"));
			country.Regions.Add(new Region("40", "Messinia"));
			country.Regions.Add(new Region("41", "Arkadhia"));
			country.Regions.Add(new Region("42", "Lakonia"));
			country.Regions.Add(new Region("43", "Khania"));
			country.Regions.Add(new Region("44", "Rethimni"));
			country.Regions.Add(new Region("45", "Iraklion"));
			country.Regions.Add(new Region("46", "Lasithi"));
			country.Regions.Add(new Region("47", "Dhodhekanisos"));
			country.Regions.Add(new Region("48", "Samos"));
			country.Regions.Add(new Region("49", "Kikladhes"));
			country.Regions.Add(new Region("50", "Khios"));
			country.Regions.Add(new Region("51", "Lesvos"));
			countryList.Add(country);

			// Greenland
			country = new Country("Greenland", "GL");
			country.Regions.Add(new Region("01", "Nordgronland"));
			country.Regions.Add(new Region("02", "Ostgronland"));
			country.Regions.Add(new Region("03", "Vestgronland"));
			countryList.Add(country);

			// Grenada
			country = new Country("Grenada", "GD");
			country.Regions.Add(new Region("01", "Saint Andrew"));
			country.Regions.Add(new Region("02", "Saint David"));
			country.Regions.Add(new Region("03", "Saint George"));
			country.Regions.Add(new Region("04", "Saint John"));
			country.Regions.Add(new Region("05", "Saint Mark"));
			country.Regions.Add(new Region("06", "Saint Patrick"));
			countryList.Add(country);

			// Guadeloupe -------------------------------------------------------------------
			country = new Country("Guadeloupe", "GP");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Guam -------------------------------------------------------------------
			country = new Country("Guam", "GU");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Guatemala
			country = new Country("Guatemala", "GT");
			country.Regions.Add(new Region("01", "Alta Verapaz"));
			country.Regions.Add(new Region("02", "Baja Verapaz"));
			country.Regions.Add(new Region("03", "Chimaltenango"));
			country.Regions.Add(new Region("04", "Chiquimula"));
			country.Regions.Add(new Region("05", "El Progreso"));
			country.Regions.Add(new Region("06", "Escuintla"));
			country.Regions.Add(new Region("07", "Guatemala"));
			country.Regions.Add(new Region("08", "Huehuetenango"));
			country.Regions.Add(new Region("09", "Izabal"));
			country.Regions.Add(new Region("10", "Jalapa"));
			country.Regions.Add(new Region("11", "Jutiapa"));
			country.Regions.Add(new Region("12", "Peten"));
			country.Regions.Add(new Region("13", "Quetzaltenango"));
			country.Regions.Add(new Region("14", "Quiche"));
			country.Regions.Add(new Region("15", "Retalhuleu"));
			country.Regions.Add(new Region("16", "Sacatepequez"));
			country.Regions.Add(new Region("17", "San Marcos"));
			country.Regions.Add(new Region("18", "Santa Rosa"));
			country.Regions.Add(new Region("19", "Solola"));
			country.Regions.Add(new Region("20", "Suchitepequez"));
			country.Regions.Add(new Region("21", "Totonicapan"));
			country.Regions.Add(new Region("22", "Zacapa"));
			countryList.Add(country);

			// Guinea
			country = new Country("Guinea", "GN");
			country.Regions.Add(new Region("01", "Beyla"));
			country.Regions.Add(new Region("02", "Boffa"));
			country.Regions.Add(new Region("03", "Boke"));
			country.Regions.Add(new Region("04", "Conakry"));
			country.Regions.Add(new Region("05", "Dabola"));
			country.Regions.Add(new Region("06", "Dalaba"));
			country.Regions.Add(new Region("07", "Dinguiraye"));
			country.Regions.Add(new Region("09", "Faranah"));
			country.Regions.Add(new Region("10", "Forecariah"));
			country.Regions.Add(new Region("11", "Fria"));
			country.Regions.Add(new Region("12", "Gaoual"));
			country.Regions.Add(new Region("13", "Gueckedou"));
			country.Regions.Add(new Region("15", "Kerouane"));
			country.Regions.Add(new Region("16", "Kindia"));
			country.Regions.Add(new Region("17", "Kissidougou"));
			country.Regions.Add(new Region("18", "Koundara"));
			country.Regions.Add(new Region("19", "Kouroussa"));
			country.Regions.Add(new Region("21", "Macenta"));
			country.Regions.Add(new Region("22", "Mali"));
			country.Regions.Add(new Region("23", "Mamou"));
			country.Regions.Add(new Region("25", "Pita"));
			country.Regions.Add(new Region("27", "Telimele"));
			country.Regions.Add(new Region("28", "Tougue"));
			country.Regions.Add(new Region("29", "Yomou"));
			country.Regions.Add(new Region("30", "Coyah"));
			country.Regions.Add(new Region("31", "Dubreka"));
			country.Regions.Add(new Region("32", "Kankan"));
			country.Regions.Add(new Region("33", "Koubia"));
			country.Regions.Add(new Region("34", "Labe"));
			country.Regions.Add(new Region("35", "Lelouma"));
			country.Regions.Add(new Region("36", "Lola"));
			country.Regions.Add(new Region("37", "Mandiana"));
			country.Regions.Add(new Region("38", "Nzerekore"));
			country.Regions.Add(new Region("39", "Siguiri"));
			countryList.Add(country);

			// Guinea-Bissau
			country = new Country("Guinea-Bissau", "GW");
			country.Regions.Add(new Region("01", "Bafata"));
			country.Regions.Add(new Region("02", "Quinara"));
			country.Regions.Add(new Region("04", "Oio"));
			country.Regions.Add(new Region("05", "Bolama"));
			country.Regions.Add(new Region("06", "Cacheu"));
			country.Regions.Add(new Region("07", "Tombali"));
			country.Regions.Add(new Region("10", "Gabu"));
			country.Regions.Add(new Region("11", "Bissau"));
			country.Regions.Add(new Region("12", "Biombo"));
			countryList.Add(country);

			// Guyana
			country = new Country("Guyana", "GY");
			country.Regions.Add(new Region("10", "Barima-Waini"));
			country.Regions.Add(new Region("11", "Cuyuni-Mazaruni"));
			country.Regions.Add(new Region("12", "Demerara-Mahaica"));
			country.Regions.Add(new Region("13", "East Berbice-Corentyne"));
			country.Regions.Add(new Region("14", "Essequibo Islands-West Demerara"));
			country.Regions.Add(new Region("15", "Mahaica-Berbice"));
			country.Regions.Add(new Region("16", "Pomeroon-Supenaam"));
			country.Regions.Add(new Region("17", "Potaro-Siparuni"));
			country.Regions.Add(new Region("18", "Upper Demerara-Berbice"));
			country.Regions.Add(new Region("19", "Upper Takutu-Upper Essequibo"));
			countryList.Add(country);

			// Haiti
			country = new Country("Haiti", "HT");
			country.Regions.Add(new Region("03", "Nord-Ouest"));
			country.Regions.Add(new Region("06", "Artibonite"));
			country.Regions.Add(new Region("07", "Centre"));
			country.Regions.Add(new Region("09", "Nord"));
			country.Regions.Add(new Region("10", "Nord-Est"));
			country.Regions.Add(new Region("11", "Ouest"));
			country.Regions.Add(new Region("12", "Sud"));
			country.Regions.Add(new Region("13", "Sud-Est"));
			country.Regions.Add(new Region("14", "Grand' Anse"));
			country.Regions.Add(new Region("15", "Nippes"));
			countryList.Add(country);

			// Heard and McDonald Islands -------------------------------------------------------------------
			//country = new Country("Heard and McDonald Islands", "HM");
			//countryList.Add(country);

			// Honduras
			country = new Country("Honduras", "HN");
			country.Regions.Add(new Region("01", "Atlantida"));
			country.Regions.Add(new Region("02", "Choluteca"));
			country.Regions.Add(new Region("03", "Colon"));
			country.Regions.Add(new Region("04", "Comayagua"));
			country.Regions.Add(new Region("05", "Copan"));
			country.Regions.Add(new Region("06", "Cortes"));
			country.Regions.Add(new Region("07", "El Paraiso"));
			country.Regions.Add(new Region("08", "Francisco Morazan"));
			country.Regions.Add(new Region("09", "Gracias a Dios"));
			country.Regions.Add(new Region("10", "Intibuca"));
			country.Regions.Add(new Region("11", "Islas de la Bahia"));
			country.Regions.Add(new Region("12", "La Paz"));
			country.Regions.Add(new Region("13", "Lempira"));
			country.Regions.Add(new Region("14", "Ocotepeque"));
			country.Regions.Add(new Region("15", "Olancho"));
			country.Regions.Add(new Region("16", "Santa Barbara"));
			country.Regions.Add(new Region("17", "Valle"));
			country.Regions.Add(new Region("18", "Yoro"));
			countryList.Add(country);

			// Hong Kong -------------------------------------------------------------------
			country = new Country("Hong Kong", "HK");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Hungary
			country = new Country("Hungary", "HU");
			country.Regions.Add(new Region("01", "Bacs-Kiskun"));
			country.Regions.Add(new Region("02", "Baranya"));
			country.Regions.Add(new Region("03", "Bekes"));
			country.Regions.Add(new Region("04", "Borsod-Abauj-Zemplen"));
			country.Regions.Add(new Region("05", "Budapest"));
			country.Regions.Add(new Region("06", "Csongrad"));
			country.Regions.Add(new Region("07", "Debrecen"));
			country.Regions.Add(new Region("08", "Fejer"));
			country.Regions.Add(new Region("09", "Gyor-Moson-Sopron"));
			country.Regions.Add(new Region("10", "Hajdu-Bihar"));
			country.Regions.Add(new Region("11", "Heves"));
			country.Regions.Add(new Region("12", "Komarom-Esztergom"));
			country.Regions.Add(new Region("13", "Miskolc"));
			country.Regions.Add(new Region("14", "Nograd"));
			country.Regions.Add(new Region("15", "Pecs"));
			country.Regions.Add(new Region("16", "Pest"));
			country.Regions.Add(new Region("17", "Somogy"));
			country.Regions.Add(new Region("18", "Szabolcs-Szatmar-Bereg"));
			country.Regions.Add(new Region("19", "Szeged"));
			country.Regions.Add(new Region("20", "Jasz-Nagykun-Szolnok"));
			country.Regions.Add(new Region("21", "Tolna"));
			country.Regions.Add(new Region("22", "Vas"));
			country.Regions.Add(new Region("23", "Veszprem"));
			country.Regions.Add(new Region("24", "Zala"));
			country.Regions.Add(new Region("25", "Gyor"));
			country.Regions.Add(new Region("26", "Bekescsaba"));
			country.Regions.Add(new Region("27", "Dunaujvaros"));
			country.Regions.Add(new Region("28", "Eger"));
			country.Regions.Add(new Region("29", "Hodmezovasarhely"));
			country.Regions.Add(new Region("30", "Kaposvar"));
			country.Regions.Add(new Region("31", "Kecskemet"));
			country.Regions.Add(new Region("32", "Nagykanizsa"));
			country.Regions.Add(new Region("33", "Nyiregyhaza"));
			country.Regions.Add(new Region("34", "Sopron"));
			country.Regions.Add(new Region("35", "Szekesfehervar"));
			country.Regions.Add(new Region("36", "Szolnok"));
			country.Regions.Add(new Region("37", "Szombathely"));
			country.Regions.Add(new Region("38", "Tatabanya"));
			country.Regions.Add(new Region("39", "Veszprem"));
			country.Regions.Add(new Region("40", "Zalaegerszeg"));
			country.Regions.Add(new Region("41", "Salgotarjan"));
			country.Regions.Add(new Region("42", "Szekszard"));
			country.Regions.Add(new Region("43", "Erd"));
			countryList.Add(country);

			// Iceland
			country = new Country("Iceland", "IS");
			country.Regions.Add(new Region("03", "Arnessysla"));
			country.Regions.Add(new Region("05", "Austur-Hunavatnssysla"));
			country.Regions.Add(new Region("06", "Austur-Skaftafellssysla"));
			country.Regions.Add(new Region("07", "Borgarfjardarsysla"));
			country.Regions.Add(new Region("09", "Eyjafjardarsysla"));
			country.Regions.Add(new Region("10", "Gullbringusysla"));
			country.Regions.Add(new Region("15", "Kjosarsysla"));
			country.Regions.Add(new Region("17", "Myrasysla"));
			country.Regions.Add(new Region("20", "Nordur-Mulasysla"));
			country.Regions.Add(new Region("21", "Nordur-Tingeyjarsysla"));
			country.Regions.Add(new Region("23", "Rangarvallasysla"));
			country.Regions.Add(new Region("28", "Skagafjardarsysla"));
			country.Regions.Add(new Region("29", "Snafellsnes- og Hnappadalssysla"));
			country.Regions.Add(new Region("30", "Strandasysla"));
			country.Regions.Add(new Region("31", "Sudur-Mulasysla"));
			country.Regions.Add(new Region("32", "Sudur-Tingeyjarsysla"));
			country.Regions.Add(new Region("34", "Vestur-Bardastrandarsysla"));
			country.Regions.Add(new Region("35", "Vestur-Hunavatnssysla"));
			country.Regions.Add(new Region("36", "Vestur-Isafjardarsysla"));
			country.Regions.Add(new Region("37", "Vestur-Skaftafellssysla"));
			country.Regions.Add(new Region("38", "Austurland"));
			country.Regions.Add(new Region("39", "Hofuoborgarsvaoio"));
			country.Regions.Add(new Region("40", "Norourland Eystra"));
			country.Regions.Add(new Region("41", "Norourland Vestra"));
			country.Regions.Add(new Region("42", "Suourland"));
			country.Regions.Add(new Region("43", "Suournes"));
			country.Regions.Add(new Region("44", "Vestfiroir"));
			country.Regions.Add(new Region("45", "Vesturland"));
			countryList.Add(country);

			// India
			country = new Country("India", "IN");
			country.Regions.Add(new Region("01", "Andaman and Nicobar Islands"));
			country.Regions.Add(new Region("02", "Andhra Pradesh"));
			country.Regions.Add(new Region("03", "Assam"));
			country.Regions.Add(new Region("05", "Chandigarh"));
			country.Regions.Add(new Region("06", "Dadra and Nagar Haveli"));
			country.Regions.Add(new Region("07", "Delhi"));
			country.Regions.Add(new Region("09", "Gujarat"));
			country.Regions.Add(new Region("10", "Haryana"));
			country.Regions.Add(new Region("11", "Himachal Pradesh"));
			country.Regions.Add(new Region("12", "Jammu and Kashmir"));
			country.Regions.Add(new Region("13", "Kerala"));
			country.Regions.Add(new Region("14", "Lakshadweep"));
			country.Regions.Add(new Region("16", "Maharashtra"));
			country.Regions.Add(new Region("17", "Manipur"));
			country.Regions.Add(new Region("18", "Meghalaya"));
			country.Regions.Add(new Region("19", "Karnataka"));
			country.Regions.Add(new Region("20", "Nagaland"));
			country.Regions.Add(new Region("21", "Orissa"));
			country.Regions.Add(new Region("22", "Puducherry"));
			country.Regions.Add(new Region("23", "Punjab"));
			country.Regions.Add(new Region("24", "Rajasthan"));
			country.Regions.Add(new Region("25", "Tamil Nadu"));
			country.Regions.Add(new Region("26", "Tripura"));
			country.Regions.Add(new Region("28", "West Bengal"));
			country.Regions.Add(new Region("29", "Sikkim"));
			country.Regions.Add(new Region("30", "Arunachal Pradesh"));
			country.Regions.Add(new Region("31", "Mizoram"));
			country.Regions.Add(new Region("32", "Daman and Diu"));
			country.Regions.Add(new Region("33", "Goa"));
			country.Regions.Add(new Region("34", "Bihar"));
			country.Regions.Add(new Region("35", "Madhya Pradesh"));
			country.Regions.Add(new Region("36", "Uttar Pradesh"));
			country.Regions.Add(new Region("37", "Chhattisgarh"));
			country.Regions.Add(new Region("38", "Jharkhand"));
			country.Regions.Add(new Region("39", "Uttarakhand"));
			countryList.Add(country);

			// Indonesia
			country = new Country("Indonesia", "ID");
			country.Regions.Add(new Region("01", "Aceh"));
			country.Regions.Add(new Region("02", "Bali"));
			country.Regions.Add(new Region("03", "Bengkulu"));
			country.Regions.Add(new Region("04", "Jakarta Raya"));
			country.Regions.Add(new Region("05", "Jambi"));
			country.Regions.Add(new Region("07", "Jawa Tengah"));
			country.Regions.Add(new Region("08", "Jawa Timur"));
			country.Regions.Add(new Region("10", "Yogyakarta"));
			country.Regions.Add(new Region("11", "Kalimantan Barat"));
			country.Regions.Add(new Region("12", "Kalimantan Selatan"));
			country.Regions.Add(new Region("13", "Kalimantan Tengah"));
			country.Regions.Add(new Region("14", "Kalimantan Timur"));
			country.Regions.Add(new Region("15", "Lampung"));
			country.Regions.Add(new Region("17", "Nusa Tenggara Barat"));
			country.Regions.Add(new Region("18", "Nusa Tenggara Timur"));
			country.Regions.Add(new Region("21", "Sulawesi Tengah"));
			country.Regions.Add(new Region("22", "Sulawesi Tenggara"));
			country.Regions.Add(new Region("24", "Sumatera Barat"));
			country.Regions.Add(new Region("26", "Sumatera Utara"));
			country.Regions.Add(new Region("28", "Maluku"));
			country.Regions.Add(new Region("29", "Maluku Utara"));
			country.Regions.Add(new Region("30", "Jawa Barat"));
			country.Regions.Add(new Region("31", "Sulawesi Utara"));
			country.Regions.Add(new Region("32", "Sumatera Selatan"));
			country.Regions.Add(new Region("33", "Banten"));
			country.Regions.Add(new Region("34", "Gorontalo"));
			country.Regions.Add(new Region("35", "Kepulauan Bangka Belitung"));
			country.Regions.Add(new Region("36", "Papua"));
			country.Regions.Add(new Region("37", "Riau"));
			country.Regions.Add(new Region("38", "Sulawesi Selatan"));
			country.Regions.Add(new Region("39", "Irian Jaya Barat"));
			country.Regions.Add(new Region("40", "Kepulauan Riau"));
			country.Regions.Add(new Region("41", "Sulawesi Barat"));
			countryList.Add(country);

			// Iran
			country = new Country("Iran", "IR");
			country.Regions.Add(new Region("01", "Azarbayjan-e Bakhtari"));
			country.Regions.Add(new Region("03", "Chahar Mahall va Bakhtiari"));
			country.Regions.Add(new Region("04", "Sistan va Baluchestan"));
			country.Regions.Add(new Region("05", "Kohkiluyeh va Buyer Ahmadi"));
			country.Regions.Add(new Region("07", "Fars"));
			country.Regions.Add(new Region("08", "Gilan"));
			country.Regions.Add(new Region("09", "Hamadan"));
			country.Regions.Add(new Region("10", "Ilam"));
			country.Regions.Add(new Region("11", "Hormozgan"));
			country.Regions.Add(new Region("12", "Kerman"));
			country.Regions.Add(new Region("13", "Bakhtaran"));
			country.Regions.Add(new Region("15", "Khuzestan"));
			country.Regions.Add(new Region("16", "Kordestan"));
			country.Regions.Add(new Region("17", "Mazandaran"));
			country.Regions.Add(new Region("18", "Semnan Province"));
			country.Regions.Add(new Region("19", "Markazi"));
			country.Regions.Add(new Region("21", "Zanjan"));
			country.Regions.Add(new Region("22", "Bushehr"));
			country.Regions.Add(new Region("23", "Lorestan"));
			country.Regions.Add(new Region("24", "Markazi"));
			country.Regions.Add(new Region("25", "Semnan"));
			country.Regions.Add(new Region("26", "Tehran"));
			country.Regions.Add(new Region("27", "Zanjan"));
			country.Regions.Add(new Region("28", "Esfahan"));
			country.Regions.Add(new Region("29", "Kerman"));
			country.Regions.Add(new Region("30", "Khorasan"));
			country.Regions.Add(new Region("31", "Yazd"));
			country.Regions.Add(new Region("32", "Ardabil"));
			country.Regions.Add(new Region("33", "East Azarbaijan"));
			country.Regions.Add(new Region("34", "Markazi"));
			country.Regions.Add(new Region("35", "Mazandaran"));
			country.Regions.Add(new Region("36", "Zanjan"));
			country.Regions.Add(new Region("37", "Golestan"));
			country.Regions.Add(new Region("38", "Qazvin"));
			country.Regions.Add(new Region("39", "Qom"));
			country.Regions.Add(new Region("40", "Yazd"));
			country.Regions.Add(new Region("41", "Khorasan-e Janubi"));
			country.Regions.Add(new Region("42", "Khorasan-e Razavi"));
			country.Regions.Add(new Region("43", "Khorasan-e Shemali"));
			country.Regions.Add(new Region("44", "Alborz"));
			countryList.Add(country);

			// Iraq
			country = new Country("Iraq", "IQ");
			country.Regions.Add(new Region("01", "Al Anbar"));
			country.Regions.Add(new Region("02", "Al Basrah"));
			country.Regions.Add(new Region("03", "Al Muthanna"));
			country.Regions.Add(new Region("04", "Al Qadisiyah"));
			country.Regions.Add(new Region("05", "As Sulaymaniyah"));
			country.Regions.Add(new Region("06", "Babil"));
			country.Regions.Add(new Region("07", "Baghdad"));
			country.Regions.Add(new Region("08", "Dahuk"));
			country.Regions.Add(new Region("09", "Dhi Qar"));
			country.Regions.Add(new Region("10", "Diyala"));
			country.Regions.Add(new Region("11", "Arbil"));
			country.Regions.Add(new Region("12", "Karbala'"));
			country.Regions.Add(new Region("13", "At Ta'mim"));
			country.Regions.Add(new Region("14", "Maysan"));
			country.Regions.Add(new Region("15", "Ninawa"));
			country.Regions.Add(new Region("16", "Wasit"));
			country.Regions.Add(new Region("17", "An Najaf"));
			country.Regions.Add(new Region("18", "Salah ad Din"));
			countryList.Add(country);

			// Ireland
			country = new Country("Ireland", "IE");
			country.Regions.Add(new Region("01", "Carlow"));
			country.Regions.Add(new Region("02", "Cavan"));
			country.Regions.Add(new Region("03", "Clare"));
			country.Regions.Add(new Region("04", "Cork"));
			country.Regions.Add(new Region("06", "Donegal"));
			country.Regions.Add(new Region("07", "Dublin"));
			country.Regions.Add(new Region("10", "Galway"));
			country.Regions.Add(new Region("11", "Kerry"));
			country.Regions.Add(new Region("12", "Kildare"));
			country.Regions.Add(new Region("13", "Kilkenny"));
			country.Regions.Add(new Region("14", "Leitrim"));
			country.Regions.Add(new Region("15", "Laois"));
			country.Regions.Add(new Region("16", "Limerick"));
			country.Regions.Add(new Region("18", "Longford"));
			country.Regions.Add(new Region("19", "Louth"));
			country.Regions.Add(new Region("20", "Mayo"));
			country.Regions.Add(new Region("21", "Meath"));
			country.Regions.Add(new Region("22", "Monaghan"));
			country.Regions.Add(new Region("23", "Offaly"));
			country.Regions.Add(new Region("24", "Roscommon"));
			country.Regions.Add(new Region("25", "Sligo"));
			country.Regions.Add(new Region("26", "Tipperary"));
			country.Regions.Add(new Region("27", "Waterford"));
			country.Regions.Add(new Region("29", "Westmeath"));
			country.Regions.Add(new Region("30", "Wexford"));
			country.Regions.Add(new Region("31", "Wicklow"));
			countryList.Add(country);

			// Israel
			country = new Country("Israel", "IL");
			country.Regions.Add(new Region("01", "HaDarom"));
			country.Regions.Add(new Region("02", "HaMerkaz"));
			country.Regions.Add(new Region("03", "HaZafon"));
			country.Regions.Add(new Region("04", "Hefa"));
			country.Regions.Add(new Region("05", "Tel Aviv"));
			country.Regions.Add(new Region("06", "Yerushalayim"));
			countryList.Add(country);

			// Italy
			country = new Country("Italy", "IT");
			country.Regions.Add(new Region("01", "Abruzzi"));
			country.Regions.Add(new Region("02", "Basilicata"));
			country.Regions.Add(new Region("03", "Calabria"));
			country.Regions.Add(new Region("04", "Campania"));
			country.Regions.Add(new Region("05", "Emilia-Romagna"));
			country.Regions.Add(new Region("06", "Friuli-Venezia Giulia"));
			country.Regions.Add(new Region("07", "Lazio"));
			country.Regions.Add(new Region("08", "Liguria"));
			country.Regions.Add(new Region("09", "Lombardia"));
			country.Regions.Add(new Region("10", "Marche"));
			country.Regions.Add(new Region("11", "Molise"));
			country.Regions.Add(new Region("12", "Piemonte"));
			country.Regions.Add(new Region("13", "Puglia"));
			country.Regions.Add(new Region("14", "Sardegna"));
			country.Regions.Add(new Region("15", "Sicilia"));
			country.Regions.Add(new Region("16", "Toscana"));
			country.Regions.Add(new Region("17", "Trentino-Alto Adige"));
			country.Regions.Add(new Region("18", "Umbria"));
			country.Regions.Add(new Region("19", "Valle d'Aosta"));
			country.Regions.Add(new Region("20", "Veneto"));
			countryList.Add(country);

			// Jamaica
			country = new Country("Jamaica", "JM");
			country.Regions.Add(new Region("01", "Clarendon"));
			country.Regions.Add(new Region("02", "Hanover"));
			country.Regions.Add(new Region("04", "Manchester"));
			country.Regions.Add(new Region("07", "Portland"));
			country.Regions.Add(new Region("08", "Saint Andrew"));
			country.Regions.Add(new Region("09", "Saint Ann"));
			country.Regions.Add(new Region("10", "Saint Catherine"));
			country.Regions.Add(new Region("11", "Saint Elizabeth"));
			country.Regions.Add(new Region("12", "Saint James"));
			country.Regions.Add(new Region("13", "Saint Mary"));
			country.Regions.Add(new Region("14", "Saint Thomas"));
			country.Regions.Add(new Region("15", "Trelawny"));
			country.Regions.Add(new Region("16", "Westmoreland"));
			country.Regions.Add(new Region("17", "Kingston"));
			countryList.Add(country);

			// Japan
			country = new Country("Japan", "JP");
			country.Regions.Add(new Region("01", "Aichi"));
			country.Regions.Add(new Region("02", "Akita"));
			country.Regions.Add(new Region("03", "Aomori"));
			country.Regions.Add(new Region("04", "Chiba"));
			country.Regions.Add(new Region("05", "Ehime"));
			country.Regions.Add(new Region("06", "Fukui"));
			country.Regions.Add(new Region("07", "Fukuoka"));
			country.Regions.Add(new Region("08", "Fukushima"));
			country.Regions.Add(new Region("09", "Gifu"));
			country.Regions.Add(new Region("10", "Gumma"));
			country.Regions.Add(new Region("11", "Hiroshima"));
			country.Regions.Add(new Region("12", "Hokkaido"));
			country.Regions.Add(new Region("13", "Hyogo"));
			country.Regions.Add(new Region("14", "Ibaraki"));
			country.Regions.Add(new Region("15", "Ishikawa"));
			country.Regions.Add(new Region("16", "Iwate"));
			country.Regions.Add(new Region("17", "Kagawa"));
			country.Regions.Add(new Region("18", "Kagoshima"));
			country.Regions.Add(new Region("19", "Kanagawa"));
			country.Regions.Add(new Region("20", "Kochi"));
			country.Regions.Add(new Region("21", "Kumamoto"));
			country.Regions.Add(new Region("22", "Kyoto"));
			country.Regions.Add(new Region("23", "Mie"));
			country.Regions.Add(new Region("24", "Miyagi"));
			country.Regions.Add(new Region("25", "Miyazaki"));
			country.Regions.Add(new Region("26", "Nagano"));
			country.Regions.Add(new Region("27", "Nagasaki"));
			country.Regions.Add(new Region("28", "Nara"));
			country.Regions.Add(new Region("29", "Niigata"));
			country.Regions.Add(new Region("30", "Oita"));
			country.Regions.Add(new Region("31", "Okayama"));
			country.Regions.Add(new Region("32", "Osaka"));
			country.Regions.Add(new Region("33", "Saga"));
			country.Regions.Add(new Region("34", "Saitama"));
			country.Regions.Add(new Region("35", "Shiga"));
			country.Regions.Add(new Region("36", "Shimane"));
			country.Regions.Add(new Region("37", "Shizuoka"));
			country.Regions.Add(new Region("38", "Tochigi"));
			country.Regions.Add(new Region("39", "Tokushima"));
			country.Regions.Add(new Region("40", "Tokyo"));
			country.Regions.Add(new Region("41", "Tottori"));
			country.Regions.Add(new Region("42", "Toyama"));
			country.Regions.Add(new Region("43", "Wakayama"));
			country.Regions.Add(new Region("44", "Yamagata"));
			country.Regions.Add(new Region("45", "Yamaguchi"));
			country.Regions.Add(new Region("46", "Yamanashi"));
			country.Regions.Add(new Region("47", "Okinawa"));
			countryList.Add(country);

			// Jordan
			country = new Country("Jordan", "JO");
			country.Regions.Add(new Region("02", "Al Balqa'"));
			country.Regions.Add(new Region("09", "Al Karak"));
			country.Regions.Add(new Region("12", "At Tafilah"));
			country.Regions.Add(new Region("15", "Al Mafraq"));
			country.Regions.Add(new Region("16", "Amman"));
			country.Regions.Add(new Region("17", "Az Zaraqa"));
			country.Regions.Add(new Region("18", "Irbid"));
			country.Regions.Add(new Region("19", "Ma'an"));
			country.Regions.Add(new Region("20", "Ajlun"));
			country.Regions.Add(new Region("21", "Al Aqabah"));
			country.Regions.Add(new Region("22", "Jarash"));
			country.Regions.Add(new Region("23", "Madaba"));
			countryList.Add(country);

			// Kazakhstan
			country = new Country("Kazakhstan", "KZ");
			country.Regions.Add(new Region("01", "Almaty"));
			country.Regions.Add(new Region("02", "Almaty City"));
			country.Regions.Add(new Region("03", "Aqmola"));
			country.Regions.Add(new Region("04", "Aqtobe"));
			country.Regions.Add(new Region("05", "Astana"));
			country.Regions.Add(new Region("06", "Atyrau"));
			country.Regions.Add(new Region("07", "West Kazakhstan"));
			country.Regions.Add(new Region("08", "Bayqonyr"));
			country.Regions.Add(new Region("09", "Mangghystau"));
			country.Regions.Add(new Region("10", "South Kazakhstan"));
			country.Regions.Add(new Region("11", "Pavlodar"));
			country.Regions.Add(new Region("12", "Qaraghandy"));
			country.Regions.Add(new Region("13", "Qostanay"));
			country.Regions.Add(new Region("14", "Qyzylorda"));
			country.Regions.Add(new Region("15", "East Kazakhstan"));
			country.Regions.Add(new Region("16", "North Kazakhstan"));
			country.Regions.Add(new Region("17", "Zhambyl"));
			countryList.Add(country);

			// Kenya
			country = new Country("Kenya", "KE");
			country.Regions.Add(new Region("01", "Central"));
			country.Regions.Add(new Region("02", "Coast"));
			country.Regions.Add(new Region("03", "Eastern"));
			country.Regions.Add(new Region("05", "Nairobi Area"));
			country.Regions.Add(new Region("06", "North-Eastern"));
			country.Regions.Add(new Region("07", "Nyanza"));
			country.Regions.Add(new Region("08", "Rift Valley"));
			country.Regions.Add(new Region("09", "Western"));
			countryList.Add(country);

			// Kiribati
			country = new Country("Kiribati", "KI");
			country.Regions.Add(new Region("01", "Gilbert Islands"));
			country.Regions.Add(new Region("02", "Line Islands"));
			country.Regions.Add(new Region("03", "Phoenix Islands"));
			countryList.Add(country);

			// North Korea
			country = new Country("North Korea", "KP");
			country.Regions.Add(new Region("01", "Chagang-do"));
			country.Regions.Add(new Region("03", "Hamgyong-namdo"));
			country.Regions.Add(new Region("06", "Hwanghae-namdo"));
			country.Regions.Add(new Region("07", "Hwanghae-bukto"));
			country.Regions.Add(new Region("08", "Kaesong-si"));
			country.Regions.Add(new Region("09", "Kangwon-do"));
			country.Regions.Add(new Region("11", "P'yongan-bukto"));
			country.Regions.Add(new Region("12", "P'yongyang-si"));
			country.Regions.Add(new Region("13", "Yanggang-do"));
			country.Regions.Add(new Region("14", "Namp'o-si"));
			country.Regions.Add(new Region("15", "P'yongan-namdo"));
			country.Regions.Add(new Region("17", "Hamgyong-bukto"));
			country.Regions.Add(new Region("18", "Najin Sonbong-si"));
			countryList.Add(country);

			// South Korea
			country = new Country("South Korea", "KR");
			country.Regions.Add(new Region("01", "Cheju-do"));
			country.Regions.Add(new Region("03", "Cholla-bukto"));
			country.Regions.Add(new Region("05", "Ch'ungch'ong-bukto"));
			country.Regions.Add(new Region("06", "Kangwon-do"));
			country.Regions.Add(new Region("10", "Pusan-jikhalsi"));
			country.Regions.Add(new Region("11", "Seoul-t'ukpyolsi"));
			country.Regions.Add(new Region("12", "Inch'on-jikhalsi"));
			country.Regions.Add(new Region("13", "Kyonggi-do"));
			country.Regions.Add(new Region("14", "Kyongsang-bukto"));
			country.Regions.Add(new Region("15", "Taegu-jikhalsi"));
			country.Regions.Add(new Region("16", "Cholla-namdo"));
			country.Regions.Add(new Region("17", "Ch'ungch'ong-namdo"));
			country.Regions.Add(new Region("18", "Kwangju-jikhalsi"));
			country.Regions.Add(new Region("19", "Taejon-jikhalsi"));
			country.Regions.Add(new Region("20", "Kyongsang-namdo"));
			country.Regions.Add(new Region("21", "Ulsan-gwangyoksi"));
			countryList.Add(country);

			// Kuwait
			country = new Country("Kuwait", "KW");
			country.Regions.Add(new Region("01", "Al Ahmadi"));
			country.Regions.Add(new Region("02", "Al Kuwayt"));
			country.Regions.Add(new Region("05", "Al Jahra"));
			country.Regions.Add(new Region("07", "Al Farwaniyah"));
			country.Regions.Add(new Region("08", "Hawalli"));
			country.Regions.Add(new Region("09", "Mubarak al Kabir"));
			countryList.Add(country);

			// Kyrgyzstan
			country = new Country("Kyrgyzstan", "KG");
			country.Regions.Add(new Region("01", "Bishkek"));
			country.Regions.Add(new Region("02", "Chuy"));
			country.Regions.Add(new Region("03", "Jalal-Abad"));
			country.Regions.Add(new Region("04", "Naryn"));
			country.Regions.Add(new Region("05", "Osh"));
			country.Regions.Add(new Region("06", "Talas"));
			country.Regions.Add(new Region("07", "Ysyk-Kol"));
			country.Regions.Add(new Region("08", "Osh"));
			country.Regions.Add(new Region("09", "Batken"));
			countryList.Add(country);

			// Laos
			country = new Country("Laos", "LA");
			country.Regions.Add(new Region("01", "Attapu"));
			country.Regions.Add(new Region("02", "Champasak"));
			country.Regions.Add(new Region("03", "Houaphan"));
			country.Regions.Add(new Region("04", "Khammouan"));
			country.Regions.Add(new Region("05", "Louang Namtha"));
			country.Regions.Add(new Region("07", "Oudomxai"));
			country.Regions.Add(new Region("08", "Phongsali"));
			country.Regions.Add(new Region("09", "Saravan"));
			country.Regions.Add(new Region("10", "Savannakhet"));
			country.Regions.Add(new Region("11", "Vientiane"));
			country.Regions.Add(new Region("13", "Xaignabouri"));
			country.Regions.Add(new Region("14", "Xiangkhoang"));
			country.Regions.Add(new Region("17", "Louangphrabang"));
			countryList.Add(country);

			// Latvia
			country = new Country("Latvia", "LV");
			country.Regions.Add(new Region("01", "Aizkraukles"));
			country.Regions.Add(new Region("02", "Aluksnes"));
			country.Regions.Add(new Region("03", "Balvu"));
			country.Regions.Add(new Region("04", "Bauskas"));
			country.Regions.Add(new Region("05", "Cesu"));
			country.Regions.Add(new Region("06", "Daugavpils"));
			country.Regions.Add(new Region("07", "Daugavpils"));
			country.Regions.Add(new Region("08", "Dobeles"));
			country.Regions.Add(new Region("09", "Gulbenes"));
			country.Regions.Add(new Region("10", "Jekabpils"));
			country.Regions.Add(new Region("11", "Jelgava"));
			country.Regions.Add(new Region("12", "Jelgavas"));
			country.Regions.Add(new Region("13", "Jurmala"));
			country.Regions.Add(new Region("14", "Kraslavas"));
			country.Regions.Add(new Region("15", "Kuldigas"));
			country.Regions.Add(new Region("16", "Liepaja"));
			country.Regions.Add(new Region("17", "Liepajas"));
			country.Regions.Add(new Region("18", "Limbazu"));
			country.Regions.Add(new Region("19", "Ludzas"));
			country.Regions.Add(new Region("20", "Madonas"));
			country.Regions.Add(new Region("21", "Ogres"));
			country.Regions.Add(new Region("22", "Preilu"));
			country.Regions.Add(new Region("23", "Rezekne"));
			country.Regions.Add(new Region("24", "Rezeknes"));
			country.Regions.Add(new Region("25", "Riga"));
			country.Regions.Add(new Region("26", "Rigas"));
			country.Regions.Add(new Region("27", "Saldus"));
			country.Regions.Add(new Region("28", "Talsu"));
			country.Regions.Add(new Region("29", "Tukuma"));
			country.Regions.Add(new Region("30", "Valkas"));
			country.Regions.Add(new Region("31", "Valmieras"));
			country.Regions.Add(new Region("32", "Ventspils"));
			country.Regions.Add(new Region("33", "Ventspils"));
			countryList.Add(country);

			// Lebanon
			country = new Country("Lebanon", "LB");
			country.Regions.Add(new Region("01", "Beqaa"));
			country.Regions.Add(new Region("02", "Al Janub"));
			country.Regions.Add(new Region("03", "Liban-Nord"));
			country.Regions.Add(new Region("04", "Beyrouth"));
			country.Regions.Add(new Region("05", "Mont-Liban"));
			country.Regions.Add(new Region("06", "Liban-Sud"));
			country.Regions.Add(new Region("07", "Nabatiye"));
			country.Regions.Add(new Region("08", "Beqaa"));
			country.Regions.Add(new Region("09", "Liban-Nord"));
			country.Regions.Add(new Region("10", "Aakk));r"));
			country.Regions.Add(new Region("11", "Baalbek-Hermel"));
			countryList.Add(country);

			// Lesotho
			country = new Country("Lesotho", "LS");
			country.Regions.Add(new Region("10", "Berea"));
			country.Regions.Add(new Region("11", "Butha-Buthe"));
			country.Regions.Add(new Region("12", "Leribe"));
			country.Regions.Add(new Region("13", "Mafeteng"));
			country.Regions.Add(new Region("14", "Maseru"));
			country.Regions.Add(new Region("15", "Mohales Hoek"));
			country.Regions.Add(new Region("16", "Mokhotlong"));
			country.Regions.Add(new Region("17", "Qachas Nek"));
			country.Regions.Add(new Region("18", "Quthing"));
			country.Regions.Add(new Region("19", "Thaba-Tseka"));
			countryList.Add(country);

			// Liberia
			country = new Country("Liberia", "LR");
			country.Regions.Add(new Region("01", "Bong"));
			country.Regions.Add(new Region("04", "Grand Cape Mount"));
			country.Regions.Add(new Region("05", "Lofa"));
			country.Regions.Add(new Region("06", "Maryland"));
			country.Regions.Add(new Region("07", "Monrovia"));
			country.Regions.Add(new Region("09", "Nimba"));
			country.Regions.Add(new Region("10", "Sino"));
			country.Regions.Add(new Region("11", "Grand Bassa"));
			country.Regions.Add(new Region("12", "Grand Cape Mount"));
			country.Regions.Add(new Region("13", "Maryland"));
			country.Regions.Add(new Region("14", "Montserrado"));
			country.Regions.Add(new Region("17", "Margibi"));
			country.Regions.Add(new Region("18", "River Cess"));
			country.Regions.Add(new Region("19", "Grand Gedeh"));
			country.Regions.Add(new Region("20", "Lofa"));
			country.Regions.Add(new Region("21", "Gbarpolu"));
			country.Regions.Add(new Region("22", "River Gee"));
			countryList.Add(country);

			// Libya
			country = new Country("Libya", "LY");
			country.Regions.Add(new Region("03", "Al Aziziyah"));
			country.Regions.Add(new Region("05", "Al Jufrah"));
			country.Regions.Add(new Region("08", "Al Kufrah"));
			country.Regions.Add(new Region("13", "Ash Shati'"));
			country.Regions.Add(new Region("30", "Murzuq"));
			country.Regions.Add(new Region("34", "Sabha"));
			country.Regions.Add(new Region("41", "Tarhunah"));
			country.Regions.Add(new Region("42", "Tubruq"));
			country.Regions.Add(new Region("45", "Zlitan"));
			country.Regions.Add(new Region("47", "Ajdabiya"));
			country.Regions.Add(new Region("48", "Al Fatih"));
			country.Regions.Add(new Region("49", "Al Jabal al Akhdar"));
			country.Regions.Add(new Region("50", "Al Khums"));
			country.Regions.Add(new Region("51", "An Nuqat al Khams"));
			country.Regions.Add(new Region("52", "Awbari"));
			country.Regions.Add(new Region("53", "Az Zawiyah"));
			country.Regions.Add(new Region("54", "Banghazi"));
			country.Regions.Add(new Region("55", "Darnah"));
			country.Regions.Add(new Region("56", "Ghadamis"));
			country.Regions.Add(new Region("57", "Gharyan"));
			country.Regions.Add(new Region("58", "Misratah"));
			country.Regions.Add(new Region("59", "Sawfajjin"));
			country.Regions.Add(new Region("60", "Surt"));
			country.Regions.Add(new Region("61", "Tarabulus"));
			country.Regions.Add(new Region("62", "Yafran"));
			countryList.Add(country);

			// Liechtenstein
			country = new Country("Liechtenstein", "LI");
			country.Regions.Add(new Region("01", "Balzers"));
			country.Regions.Add(new Region("02", "Eschen"));
			country.Regions.Add(new Region("03", "Gamprin"));
			country.Regions.Add(new Region("04", "Mauren"));
			country.Regions.Add(new Region("05", "Planken"));
			country.Regions.Add(new Region("06", "Ruggell"));
			country.Regions.Add(new Region("07", "Schaan"));
			country.Regions.Add(new Region("08", "Schellenberg"));
			country.Regions.Add(new Region("09", "Triesen"));
			country.Regions.Add(new Region("10", "Triesenberg"));
			country.Regions.Add(new Region("11", "Vaduz"));
			country.Regions.Add(new Region("21", "Gbarpolu"));
			country.Regions.Add(new Region("22", "River Gee"));
			countryList.Add(country);

			// Lithuania
			country = new Country("Lithuania", "LT");
			country.Regions.Add(new Region("56", "Alytaus Apskritis"));
			country.Regions.Add(new Region("57", "Kauno Apskritis"));
			country.Regions.Add(new Region("58", "Klaipedos Apskritis"));
			country.Regions.Add(new Region("59", "Marijampoles Apskritis"));
			country.Regions.Add(new Region("60", "Panevezio Apskritis"));
			country.Regions.Add(new Region("61", "Siauliu Apskritis"));
			country.Regions.Add(new Region("62", "Taurages Apskritis"));
			country.Regions.Add(new Region("63", "Telsiu Apskritis"));
			country.Regions.Add(new Region("64", "Utenos Apskritis"));
			country.Regions.Add(new Region("65", "Vilniaus Apskritis"));
			countryList.Add(country);

			// Luxembourg
			country = new Country("Luxembourg", "LU");
			country.Regions.Add(new Region("01", "Diekirch"));
			country.Regions.Add(new Region("02", "Grevenmacher"));
			country.Regions.Add(new Region("03", "Luxembourg"));
			countryList.Add(country);

			// Macau
			country = new Country("Macau", "MO");
			country.Regions.Add(new Region("01", "Ilhas"));
			country.Regions.Add(new Region("02", "Macau"));
			countryList.Add(country);

			// Macedonia
			country = new Country("Macedonia", "MK");
			country.Regions.Add(new Region("01", "Aracinovo"));
			country.Regions.Add(new Region("02", "Bac"));
			country.Regions.Add(new Region("03", "Belcista"));
			country.Regions.Add(new Region("04", "Berovo"));
			country.Regions.Add(new Region("05", "Bistrica"));
			country.Regions.Add(new Region("06", "Bitola"));
			country.Regions.Add(new Region("07", "Blatec"));
			country.Regions.Add(new Region("08", "Bogdanci"));
			country.Regions.Add(new Region("09", "Bogomila"));
			country.Regions.Add(new Region("10", "Bogovinje"));
			country.Regions.Add(new Region("11", "Bosilovo"));
			country.Regions.Add(new Region("12", "Brvenica"));
			country.Regions.Add(new Region("13", "Cair"));
			country.Regions.Add(new Region("14", "Capari"));
			country.Regions.Add(new Region("15", "Caska"));
			country.Regions.Add(new Region("16", "Cegrane"));
			country.Regions.Add(new Region("17", "Centar"));
			country.Regions.Add(new Region("18", "Centar Zupa"));
			country.Regions.Add(new Region("19", "Cesinovo"));
			country.Regions.Add(new Region("20", "Cucer-Sandevo"));
			country.Regions.Add(new Region("21", "Debar"));
			country.Regions.Add(new Region("22", "Delcevo"));
			country.Regions.Add(new Region("23", "Delogozdi"));
			country.Regions.Add(new Region("24", "Demir Hisar"));
			country.Regions.Add(new Region("25", "Demir Kapija"));
			country.Regions.Add(new Region("26", "Dobrusevo"));
			country.Regions.Add(new Region("27", "Dolna Banjica"));
			country.Regions.Add(new Region("28", "Dolneni"));
			country.Regions.Add(new Region("29", "Dorce Petrov"));
			country.Regions.Add(new Region("30", "Drugovo"));
			country.Regions.Add(new Region("31", "Dzepciste"));
			country.Regions.Add(new Region("32", "Gazi Baba"));
			country.Regions.Add(new Region("33", "Gevgelija"));
			country.Regions.Add(new Region("34", "Gostivar"));
			country.Regions.Add(new Region("35", "Gradsko"));
			country.Regions.Add(new Region("36", "Ilinden"));
			country.Regions.Add(new Region("37", "Izvor"));
			country.Regions.Add(new Region("38", "Jegunovce"));
			country.Regions.Add(new Region("39", "Kamenjane"));
			country.Regions.Add(new Region("40", "Karbinci"));
			country.Regions.Add(new Region("41", "Karpos"));
			country.Regions.Add(new Region("42", "Kavadarci"));
			country.Regions.Add(new Region("43", "Kicevo"));
			country.Regions.Add(new Region("44", "Kisela Voda"));
			country.Regions.Add(new Region("45", "Klecevce"));
			country.Regions.Add(new Region("46", "Kocani"));
			country.Regions.Add(new Region("47", "Konce"));
			country.Regions.Add(new Region("48", "Kondovo"));
			country.Regions.Add(new Region("49", "Konopiste"));
			country.Regions.Add(new Region("50", "Kosel"));
			country.Regions.Add(new Region("51", "Kratovo"));
			country.Regions.Add(new Region("52", "Kriva Palanka"));
			country.Regions.Add(new Region("53", "Krivogastani"));
			country.Regions.Add(new Region("54", "Krusevo"));
			country.Regions.Add(new Region("55", "Kuklis"));
			country.Regions.Add(new Region("56", "Kukurecani"));
			country.Regions.Add(new Region("57", "Kumanovo"));
			country.Regions.Add(new Region("58", "Labunista"));
			country.Regions.Add(new Region("59", "Lipkovo"));
			country.Regions.Add(new Region("60", "Lozovo"));
			country.Regions.Add(new Region("61", "Lukovo"));
			country.Regions.Add(new Region("62", "Makedonska Kamenica"));
			country.Regions.Add(new Region("63", "Makedonski Brod"));
			country.Regions.Add(new Region("64", "Mavrovi Anovi"));
			country.Regions.Add(new Region("65", "Meseista"));
			country.Regions.Add(new Region("66", "Miravci"));
			country.Regions.Add(new Region("67", "Mogila"));
			country.Regions.Add(new Region("68", "Murtino"));
			country.Regions.Add(new Region("69", "Negotino"));
			country.Regions.Add(new Region("70", "Negotino-Polosko"));
			country.Regions.Add(new Region("71", "Novaci"));
			country.Regions.Add(new Region("72", "Novo Selo"));
			country.Regions.Add(new Region("73", "Oblesevo"));
			country.Regions.Add(new Region("74", "Ohrid"));
			country.Regions.Add(new Region("75", "Orasac"));
			country.Regions.Add(new Region("76", "Orizari"));
			country.Regions.Add(new Region("77", "Oslomej"));
			country.Regions.Add(new Region("78", "Pehcevo"));
			country.Regions.Add(new Region("79", "Petrovec"));
			country.Regions.Add(new Region("80", "Plasnica"));
			country.Regions.Add(new Region("81", "Podares"));
			country.Regions.Add(new Region("82", "Prilep"));
			country.Regions.Add(new Region("83", "Probistip"));
			country.Regions.Add(new Region("84", "Radovis"));
			country.Regions.Add(new Region("85", "Rankovce"));
			country.Regions.Add(new Region("86", "Resen"));
			country.Regions.Add(new Region("87", "Rosoman"));
			country.Regions.Add(new Region("88", "Rostusa"));
			country.Regions.Add(new Region("89", "Samokov"));
			country.Regions.Add(new Region("90", "Saraj"));
			country.Regions.Add(new Region("91", "Sipkovica"));
			country.Regions.Add(new Region("92", "Sopiste"));
			country.Regions.Add(new Region("93", "Sopotnica"));
			country.Regions.Add(new Region("94", "Srbinovo"));
			country.Regions.Add(new Region("95", "Staravina"));
			country.Regions.Add(new Region("96", "Star Dojran"));
			country.Regions.Add(new Region("97", "Staro Nagoricane"));
			country.Regions.Add(new Region("98", "Stip"));
			country.Regions.Add(new Region("99", "Struga"));
			country.Regions.Add(new Region("A1", "Strumica"));
			country.Regions.Add(new Region("A2", "Studenicani"));
			country.Regions.Add(new Region("A3", "Suto Orizari"));
			country.Regions.Add(new Region("A4", "Sveti Nikole"));
			country.Regions.Add(new Region("A5", "Tearce"));
			country.Regions.Add(new Region("A6", "Tetovo"));
			country.Regions.Add(new Region("A7", "Topolcani"));
			country.Regions.Add(new Region("A8", "Valandovo"));
			country.Regions.Add(new Region("A9", "Vasilevo"));
			country.Regions.Add(new Region("B1", "Veles"));
			country.Regions.Add(new Region("B2", "Velesta"));
			country.Regions.Add(new Region("B3", "Vevcani"));
			country.Regions.Add(new Region("B4", "Vinica"));
			country.Regions.Add(new Region("B5", "Vitoliste"));
			country.Regions.Add(new Region("B6", "Vranestica"));
			country.Regions.Add(new Region("B7", "Vrapciste"));
			country.Regions.Add(new Region("B8", "Vratnica"));
			country.Regions.Add(new Region("B9", "Vrutok"));
			country.Regions.Add(new Region("C1", "Zajas"));
			country.Regions.Add(new Region("C2", "Zelenikovo"));
			country.Regions.Add(new Region("C3", "Zelino"));
			country.Regions.Add(new Region("C4", "Zitose"));
			country.Regions.Add(new Region("C5", "Zletovo"));
			country.Regions.Add(new Region("C6", "Zrnovci"));
			countryList.Add(country);

			// Madagascar
			country = new Country("Madagascar", "MG");
			country.Regions.Add(new Region("01", "Antsiranana"));
			country.Regions.Add(new Region("02", "Fianarantsoa"));
			country.Regions.Add(new Region("03", "Mahajanga"));
			country.Regions.Add(new Region("04", "Toamasina"));
			country.Regions.Add(new Region("05", "Antananarivo"));
			country.Regions.Add(new Region("06", "Toliara"));
			countryList.Add(country);

			// Malawi
			country = new Country("Malawi", "MW");
			country.Regions.Add(new Region("02", "Chikwawa"));
			country.Regions.Add(new Region("03", "Chiradzulu"));
			country.Regions.Add(new Region("04", "Chitipa"));
			country.Regions.Add(new Region("05", "Thyolo"));
			country.Regions.Add(new Region("06", "Dedza"));
			country.Regions.Add(new Region("07", "Dowa"));
			country.Regions.Add(new Region("08", "Karonga"));
			country.Regions.Add(new Region("09", "Kasungu"));
			country.Regions.Add(new Region("11", "Lilongwe"));
			country.Regions.Add(new Region("12", "Mangochi"));
			country.Regions.Add(new Region("13", "Mchinji"));
			country.Regions.Add(new Region("15", "Mzimba"));
			country.Regions.Add(new Region("16", "Ntcheu"));
			country.Regions.Add(new Region("17", "Nkhata Bay"));
			country.Regions.Add(new Region("18", "Nkhotakota"));
			country.Regions.Add(new Region("19", "Nsanje"));
			country.Regions.Add(new Region("20", "Ntchisi"));
			country.Regions.Add(new Region("21", "Rumphi"));
			country.Regions.Add(new Region("22", "Salima"));
			country.Regions.Add(new Region("23", "Zomba"));
			country.Regions.Add(new Region("24", "Blantyre"));
			country.Regions.Add(new Region("25", "Mwanza"));
			country.Regions.Add(new Region("26", "Balaka"));
			country.Regions.Add(new Region("27", "Likoma"));
			country.Regions.Add(new Region("28", "Machinga"));
			country.Regions.Add(new Region("29", "Mulanje"));
			country.Regions.Add(new Region("30", "Phalombe"));
			countryList.Add(country);

			// Malaysia
			country = new Country("Malaysia", "MY");
			country.Regions.Add(new Region("01", "Johor"));
			country.Regions.Add(new Region("02", "Kedah"));
			country.Regions.Add(new Region("03", "Kelantan"));
			country.Regions.Add(new Region("04", "Melaka"));
			country.Regions.Add(new Region("05", "Negeri Sembilan"));
			country.Regions.Add(new Region("06", "Pahang"));
			country.Regions.Add(new Region("07", "Perak"));
			country.Regions.Add(new Region("08", "Perlis"));
			country.Regions.Add(new Region("09", "Pulau Pinang"));
			country.Regions.Add(new Region("11", "Sarawak"));
			country.Regions.Add(new Region("12", "Selangor"));
			country.Regions.Add(new Region("13", "Terengganu"));
			country.Regions.Add(new Region("14", "Kuala Lumpur"));
			country.Regions.Add(new Region("15", "Labuan"));
			country.Regions.Add(new Region("16", "Sabah"));
			country.Regions.Add(new Region("17", "Putrajaya"));
			countryList.Add(country);

			// Maldives
			country = new Country("Maldives", "MV");
			country.Regions.Add(new Region("01", "Seenu"));
			country.Regions.Add(new Region("05", "Laamu"));
			country.Regions.Add(new Region("30", "Alifu"));
			country.Regions.Add(new Region("31", "Baa"));
			country.Regions.Add(new Region("32", "Dhaalu"));
			country.Regions.Add(new Region("33", "Faafu "));
			country.Regions.Add(new Region("34", "Gaafu Alifu"));
			country.Regions.Add(new Region("35", "Gaafu Dhaalu"));
			country.Regions.Add(new Region("36", "Haa Alifu"));
			country.Regions.Add(new Region("37", "Haa Dhaalu"));
			country.Regions.Add(new Region("38", "Kaafu"));
			country.Regions.Add(new Region("39", "Lhaviyani"));
			country.Regions.Add(new Region("40", "Maale"));
			country.Regions.Add(new Region("41", "Meemu"));
			country.Regions.Add(new Region("42", "Gnaviyani"));
			country.Regions.Add(new Region("43", "Noonu"));
			country.Regions.Add(new Region("44", "Raa"));
			country.Regions.Add(new Region("45", "Shaviyani"));
			country.Regions.Add(new Region("46", "Thaa"));
			country.Regions.Add(new Region("47", "Vaavu"));
			countryList.Add(country);

			// Mali
			country = new Country("Mali", "ML");
			country.Regions.Add(new Region("01", "Bamako"));
			country.Regions.Add(new Region("03", "Kayes"));
			country.Regions.Add(new Region("04", "Mopti"));
			country.Regions.Add(new Region("05", "Segou"));
			country.Regions.Add(new Region("06", "Sikasso"));
			country.Regions.Add(new Region("07", "Koulikoro"));
			country.Regions.Add(new Region("08", "Tombouctou"));
			country.Regions.Add(new Region("09", "Gao"));
			country.Regions.Add(new Region("10", "Kidal"));
			countryList.Add(country);

			// Malta -------------------------------------------------------------------
			country = new Country("Malta", "MT");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Marshall Islands -------------------------------------------------------------------
			country = new Country("Marshall Islands", "MH");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Martinique -------------------------------------------------------------------
			country = new Country("Martinique", "MQ");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Mauritania
			country = new Country("Mauritania", "MR");
			country.Regions.Add(new Region("01", "Hodh Ech Chargui"));
			country.Regions.Add(new Region("02", "Hodh El Gharbi"));
			country.Regions.Add(new Region("03", "Assaba"));
			country.Regions.Add(new Region("04", "Gorgol"));
			country.Regions.Add(new Region("05", "Brakna"));
			country.Regions.Add(new Region("06", "Trarza"));
			country.Regions.Add(new Region("07", "Adrar"));
			country.Regions.Add(new Region("08", "Dakhlet Nouadhibou"));
			country.Regions.Add(new Region("09", "Tagant"));
			country.Regions.Add(new Region("10", "Guidimaka"));
			country.Regions.Add(new Region("11", "Tiris Zemmour"));
			country.Regions.Add(new Region("12", "Inchiri"));
			countryList.Add(country);

			// Mauritius
			country = new Country("Mauritius", "MU");
			country.Regions.Add(new Region("12", "Black River"));
			country.Regions.Add(new Region("13", "Flacq"));
			country.Regions.Add(new Region("14", "Grand Port"));
			country.Regions.Add(new Region("15", "Moka"));
			country.Regions.Add(new Region("16", "Pamplemousses"));
			country.Regions.Add(new Region("17", "Plaines Wilhems"));
			country.Regions.Add(new Region("18", "Port Louis"));
			country.Regions.Add(new Region("19", "Riviere du Rempart"));
			country.Regions.Add(new Region("20", "Savanne"));
			country.Regions.Add(new Region("21", "Agalega Islands"));
			country.Regions.Add(new Region("22", "Cargados Carajos"));
			country.Regions.Add(new Region("23", "Rodrigues"));
			countryList.Add(country);

			// Mayotte -------------------------------------------------------------------
			country = new Country("Mayotte", "YT");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Mexico
			country = new Country("Mexico", "MX");
			country.Regions.Add(new Region("01", "Aguascalientes"));
			country.Regions.Add(new Region("02", "Baja California"));
			country.Regions.Add(new Region("03", "Baja California Sur"));
			country.Regions.Add(new Region("04", "Campeche"));
			country.Regions.Add(new Region("05", "Chiapas"));
			country.Regions.Add(new Region("06", "Chihuahua"));
			country.Regions.Add(new Region("07", "Coahuila de Zaragoza"));
			country.Regions.Add(new Region("08", "Colima"));
			country.Regions.Add(new Region("09", "Distrito Federal"));
			country.Regions.Add(new Region("10", "Durango"));
			country.Regions.Add(new Region("11", "Guanajuato"));
			country.Regions.Add(new Region("12", "Guerrero"));
			country.Regions.Add(new Region("13", "Hidalgo"));
			country.Regions.Add(new Region("14", "Jalisco"));
			country.Regions.Add(new Region("15", "Mexico"));
			country.Regions.Add(new Region("16", "Michoacan de Ocampo"));
			country.Regions.Add(new Region("17", "Morelos"));
			country.Regions.Add(new Region("18", "Nayarit"));
			country.Regions.Add(new Region("19", "Nuevo Leon"));
			country.Regions.Add(new Region("20", "Oaxaca"));
			country.Regions.Add(new Region("21", "Puebla"));
			country.Regions.Add(new Region("22", "Queretaro de Arteaga"));
			country.Regions.Add(new Region("23", "Quintana Roo"));
			country.Regions.Add(new Region("24", "San Luis Potosi"));
			country.Regions.Add(new Region("25", "Sinaloa"));
			country.Regions.Add(new Region("26", "Sonora"));
			country.Regions.Add(new Region("27", "Tabasco"));
			country.Regions.Add(new Region("28", "Tamaulipas"));
			country.Regions.Add(new Region("29", "Tlaxcala"));
			country.Regions.Add(new Region("30", "Veracruz-Llave"));
			country.Regions.Add(new Region("31", "Yucatan"));
			country.Regions.Add(new Region("32", "Zacatecas"));
			countryList.Add(country);

			// Micronesia
			country = new Country("Micronesia", "FM");
			country.Regions.Add(new Region("01", "Kosrae"));
			country.Regions.Add(new Region("02", "Pohnpei"));
			country.Regions.Add(new Region("03", "Chuuk"));
			country.Regions.Add(new Region("04", "Yap"));
			countryList.Add(country);

			// Moldova
			country = new Country("Moldova", "MD");
			country.Regions.Add(new Region("51", "Gagauzia"));
			country.Regions.Add(new Region("57", "Chisinau"));
			country.Regions.Add(new Region("58", "Stinga Nistrului"));
			country.Regions.Add(new Region("59", "Anenii Noi"));
			country.Regions.Add(new Region("60", "Balti"));
			country.Regions.Add(new Region("61", "Basarabeasca"));
			country.Regions.Add(new Region("62", "Bender"));
			country.Regions.Add(new Region("63", "Briceni"));
			country.Regions.Add(new Region("64", "Cahul"));
			country.Regions.Add(new Region("65", "Cantemir"));
			country.Regions.Add(new Region("66", "Calarasi"));
			country.Regions.Add(new Region("67", "Causeni"));
			country.Regions.Add(new Region("68", "Cimislia"));
			country.Regions.Add(new Region("69", "Criuleni"));
			country.Regions.Add(new Region("70", "Donduseni"));
			country.Regions.Add(new Region("71", "Drochia"));
			country.Regions.Add(new Region("72", "Dubasari"));
			country.Regions.Add(new Region("73", "Edinet"));
			country.Regions.Add(new Region("74", "Falesti"));
			country.Regions.Add(new Region("75", "Floresti"));
			country.Regions.Add(new Region("76", "Glodeni"));
			country.Regions.Add(new Region("77", "Hincesti"));
			country.Regions.Add(new Region("78", "Ialoveni"));
			country.Regions.Add(new Region("79", "Leova"));
			country.Regions.Add(new Region("80", "Nisporeni"));
			country.Regions.Add(new Region("81", "Ocnita"));
			country.Regions.Add(new Region("82", "Orhei"));
			country.Regions.Add(new Region("83", "Rezina"));
			country.Regions.Add(new Region("84", "Riscani"));
			country.Regions.Add(new Region("85", "Singerei"));
			country.Regions.Add(new Region("86", "Soldanesti"));
			country.Regions.Add(new Region("87", "Soroca"));
			country.Regions.Add(new Region("88", "Stefan-Voda"));
			country.Regions.Add(new Region("89", "Straseni"));
			country.Regions.Add(new Region("90", "Taraclia"));
			country.Regions.Add(new Region("91", "Telenesti"));
			country.Regions.Add(new Region("92", "Ungheni"));
			countryList.Add(country);

			// Monaco
			country = new Country("Monaco", "MC");
			country.Regions.Add(new Region("01", "La Condamine"));
			country.Regions.Add(new Region("02", "Monaco"));
			country.Regions.Add(new Region("03", "Monte-Carlo"));
			countryList.Add(country);

			// Mongolia
			country = new Country("Mongolia", "MN");
			country.Regions.Add(new Region("01", "Arhangay"));
			country.Regions.Add(new Region("02", "Bayanhongor"));
			country.Regions.Add(new Region("03", "Bayan-Olgiy"));
			country.Regions.Add(new Region("05", "Darhan"));
			country.Regions.Add(new Region("06", "Dornod"));
			country.Regions.Add(new Region("07", "Dornogovi"));
			country.Regions.Add(new Region("08", "Dundgovi"));
			country.Regions.Add(new Region("09", "Dzavhan"));
			country.Regions.Add(new Region("10", "Govi-Altay"));
			country.Regions.Add(new Region("11", "Hentiy"));
			country.Regions.Add(new Region("12", "Hovd"));
			country.Regions.Add(new Region("13", "Hovsgol"));
			country.Regions.Add(new Region("14", "Omnogovi"));
			country.Regions.Add(new Region("15", "Ovorhangay"));
			country.Regions.Add(new Region("16", "Selenge"));
			country.Regions.Add(new Region("17", "Suhbaatar"));
			country.Regions.Add(new Region("18", "Tov"));
			country.Regions.Add(new Region("19", "Uvs"));
			country.Regions.Add(new Region("20", "Ulaanbaatar"));
			country.Regions.Add(new Region("21", "Bulgan"));
			country.Regions.Add(new Region("22", "Erdenet"));
			country.Regions.Add(new Region("23", "Darhan-Uul"));
			country.Regions.Add(new Region("24", "Govisumber"));
			country.Regions.Add(new Region("25", "Orhon"));
			countryList.Add(country);

			// Montserrat
			country = new Country("Montserrat", "MS");
			country.Regions.Add(new Region("01", "Saint Anthony"));
			country.Regions.Add(new Region("02", "Saint Georges"));
			country.Regions.Add(new Region("03", "Saint Peter"));
			countryList.Add(country);

			// Morocco
			country = new Country("Morocco", "MA");
			country.Regions.Add(new Region("45", "Grand Casablanca"));
			country.Regions.Add(new Region("46", "Fes-Boulemane"));
			country.Regions.Add(new Region("47", "Marrakech-Tensift-Al Haouz"));
			country.Regions.Add(new Region("48", "Meknes-Tafilalet"));
			country.Regions.Add(new Region("49", "Rabat-Sale-Zemmour-Zaer"));
			country.Regions.Add(new Region("50", "Chaouia-Ouardigha"));
			country.Regions.Add(new Region("51", "Doukkala-Abda"));
			country.Regions.Add(new Region("52", "Gharb-Chrarda-Beni Hssen"));
			country.Regions.Add(new Region("53", "Guelmim-Es Smara"));
			country.Regions.Add(new Region("54", "Oriental"));
			country.Regions.Add(new Region("55", "Souss-Massa-Dr));a"));
			country.Regions.Add(new Region("56", "Tadla-Azilal"));
			country.Regions.Add(new Region("57", "Tanger-Tetouan"));
			country.Regions.Add(new Region("58", "Taza-Al Hoceima-Taounate"));
			country.Regions.Add(new Region("59", "La));youne-Boujdour-Sakia El Hamra"));
			countryList.Add(country);

			// Mozambique
			country = new Country("Mozambique", "MZ");
			country.Regions.Add(new Region("01", "Cabo Delgado"));
			country.Regions.Add(new Region("02", "Gaza"));
			country.Regions.Add(new Region("03", "Inhambane"));
			country.Regions.Add(new Region("04", "Maputo"));
			country.Regions.Add(new Region("05", "Sofala"));
			country.Regions.Add(new Region("06", "Nampula"));
			country.Regions.Add(new Region("07", "Niassa"));
			country.Regions.Add(new Region("08", "Tete"));
			country.Regions.Add(new Region("09", "Zambezia"));
			country.Regions.Add(new Region("10", "Manica"));
			country.Regions.Add(new Region("11", "Maputo"));
			countryList.Add(country);

			// Myanmar
			country = new Country("Myanmar", "MM");
			country.Regions.Add(new Region("01", "Rakhine State"));
			country.Regions.Add(new Region("02", "Chin State"));
			country.Regions.Add(new Region("03", "Irrawaddy"));
			country.Regions.Add(new Region("04", "Kachin State"));
			country.Regions.Add(new Region("05", "Karan State"));
			country.Regions.Add(new Region("06", "Kayah State"));
			country.Regions.Add(new Region("07", "Magwe"));
			country.Regions.Add(new Region("08", "Mandalay"));
			country.Regions.Add(new Region("09", "Pegu"));
			country.Regions.Add(new Region("10", "Sagaing"));
			country.Regions.Add(new Region("11", "Shan State"));
			country.Regions.Add(new Region("12", "Tenasserim"));
			country.Regions.Add(new Region("13", "Mon State"));
			country.Regions.Add(new Region("14", "Rangoon"));
			country.Regions.Add(new Region("17", "Yangon"));
			countryList.Add(country);

			// Namibia
			country = new Country("Namibia", "NA");
			country.Regions.Add(new Region("01", "Bethanien"));
			country.Regions.Add(new Region("02", "Caprivi Oos"));
			country.Regions.Add(new Region("03", "Boesmanland"));
			country.Regions.Add(new Region("04", "Gobabis"));
			country.Regions.Add(new Region("05", "Grootfontein"));
			country.Regions.Add(new Region("06", "Kaokoland"));
			country.Regions.Add(new Region("07", "Karibib"));
			country.Regions.Add(new Region("08", "Keetmanshoop"));
			country.Regions.Add(new Region("09", "Luderitz"));
			country.Regions.Add(new Region("10", "Maltahohe"));
			country.Regions.Add(new Region("11", "Okahandja"));
			country.Regions.Add(new Region("12", "Omaruru"));
			country.Regions.Add(new Region("13", "Otjiwarongo"));
			country.Regions.Add(new Region("14", "Outjo"));
			country.Regions.Add(new Region("15", "Owambo"));
			country.Regions.Add(new Region("16", "Rehoboth"));
			country.Regions.Add(new Region("17", "Swakopmund"));
			country.Regions.Add(new Region("18", "Tsumeb"));
			country.Regions.Add(new Region("20", "Karasburg"));
			country.Regions.Add(new Region("21", "Windhoek"));
			country.Regions.Add(new Region("22", "Damaraland"));
			country.Regions.Add(new Region("23", "Hereroland Oos"));
			country.Regions.Add(new Region("24", "Hereroland Wes"));
			country.Regions.Add(new Region("25", "Kavango"));
			country.Regions.Add(new Region("26", "Mariental"));
			country.Regions.Add(new Region("27", "Namaland"));
			country.Regions.Add(new Region("28", "Caprivi"));
			country.Regions.Add(new Region("29", "Erongo"));
			country.Regions.Add(new Region("30", "Hardap"));
			country.Regions.Add(new Region("31", "Karas"));
			country.Regions.Add(new Region("32", "Kunene"));
			country.Regions.Add(new Region("33", "Ohangwena"));
			country.Regions.Add(new Region("34", "Okavango"));
			country.Regions.Add(new Region("35", "Omaheke"));
			country.Regions.Add(new Region("36", "Omusati"));
			country.Regions.Add(new Region("37", "Oshana"));
			country.Regions.Add(new Region("38", "Oshikoto"));
			country.Regions.Add(new Region("39", "Otjozondjupa"));
			countryList.Add(country);

			// Nauru
			country = new Country("Nauru", "NR");
			country.Regions.Add(new Region("01", "Aiwo"));
			country.Regions.Add(new Region("02", "Anabar"));
			country.Regions.Add(new Region("03", "Anetan"));
			country.Regions.Add(new Region("04", "Anibare"));
			country.Regions.Add(new Region("05", "Baiti"));
			country.Regions.Add(new Region("06", "Boe"));
			country.Regions.Add(new Region("07", "Buada"));
			country.Regions.Add(new Region("08", "Denigomodu"));
			country.Regions.Add(new Region("09", "Ewa"));
			country.Regions.Add(new Region("10", "Ijuw"));
			country.Regions.Add(new Region("11", "Meneng"));
			country.Regions.Add(new Region("12", "Nibok"));
			country.Regions.Add(new Region("13", "Uaboe"));
			country.Regions.Add(new Region("14", "Yaren"));
			countryList.Add(country);

			// Nepal
			country = new Country("Nepal", "NP");
			country.Regions.Add(new Region("01", "Bagmati"));
			country.Regions.Add(new Region("02", "Bheri"));
			country.Regions.Add(new Region("03", "Dhawalagiri"));
			country.Regions.Add(new Region("04", "Gandaki"));
			country.Regions.Add(new Region("05", "Janakpur"));
			country.Regions.Add(new Region("06", "Karnali"));
			country.Regions.Add(new Region("07", "Kosi"));
			country.Regions.Add(new Region("08", "Lumbini"));
			country.Regions.Add(new Region("09", "Mahakali"));
			country.Regions.Add(new Region("10", "Mechi"));
			country.Regions.Add(new Region("11", "Narayani"));
			country.Regions.Add(new Region("12", "Rapti"));
			country.Regions.Add(new Region("13", "Sagarmatha"));
			country.Regions.Add(new Region("14", "Seti"));
			countryList.Add(country);

			// Netherlands
			country = new Country("Netherlands", "NL");
			country.Regions.Add(new Region("01", "Drenthe"));
			country.Regions.Add(new Region("02", "Friesland"));
			country.Regions.Add(new Region("03", "Gelderland"));
			country.Regions.Add(new Region("04", "Groningen"));
			country.Regions.Add(new Region("05", "Limburg"));
			country.Regions.Add(new Region("06", "Noord-Brabant"));
			country.Regions.Add(new Region("07", "Noord-Holland"));
			country.Regions.Add(new Region("09", "Utrecht"));
			country.Regions.Add(new Region("10", "Zeeland"));
			country.Regions.Add(new Region("11", "Zuid-Holland"));
			country.Regions.Add(new Region("15", "Overijssel"));
			country.Regions.Add(new Region("16", "Flevoland"));
			countryList.Add(country);

			// Netherlands Antilles -------------------------------------------------------------------
			country = new Country("Netherlands Antilles", "AN");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// New Caledoni -------------------------------------------------------------------
			country = new Country("New Caledonia", "NC");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// New Zealand
			country = new Country("New Zealand", "NZ");
			country.Regions.Add(new Region("10", "Chatham Islands"));
			country.Regions.Add(new Region("E7", "Auckland"));
			country.Regions.Add(new Region("E8", "Bay of Plenty"));
			country.Regions.Add(new Region("E9", "Canterbury"));
			country.Regions.Add(new Region("F1", "Gisborne"));
			country.Regions.Add(new Region("F2", "Hawke's Bay"));
			country.Regions.Add(new Region("F3", "Manawatu-Wanganui"));
			country.Regions.Add(new Region("F4", "Marlborough"));
			country.Regions.Add(new Region("F5", "Nelson"));
			country.Regions.Add(new Region("F6", "Northland"));
			country.Regions.Add(new Region("F7", "Otago"));
			country.Regions.Add(new Region("F8", "Southland"));
			country.Regions.Add(new Region("F9", "Taranaki"));
			country.Regions.Add(new Region("G1", "Waikato"));
			country.Regions.Add(new Region("G2", "Wellington"));
			country.Regions.Add(new Region("G3", "West Coast"));
			countryList.Add(country);

			// Nicaragua
			country = new Country("Nicaragua", "NI");
			country.Regions.Add(new Region("01", "Boaco"));
			country.Regions.Add(new Region("02", "Carazo"));
			country.Regions.Add(new Region("03", "Chinandega"));
			country.Regions.Add(new Region("04", "Chontales"));
			country.Regions.Add(new Region("05", "Esteli"));
			country.Regions.Add(new Region("06", "Granada"));
			country.Regions.Add(new Region("07", "Jinotega"));
			country.Regions.Add(new Region("08", "Leon"));
			country.Regions.Add(new Region("09", "Madriz"));
			country.Regions.Add(new Region("10", "Managua"));
			country.Regions.Add(new Region("11", "Masaya"));
			country.Regions.Add(new Region("12", "Matagalpa"));
			country.Regions.Add(new Region("13", "Nueva Segovia"));
			country.Regions.Add(new Region("14", "Rio San Juan"));
			country.Regions.Add(new Region("15", "Rivas"));
			country.Regions.Add(new Region("16", "Zelaya"));
			country.Regions.Add(new Region("17", "Autonoma Atlantico Norte"));
			country.Regions.Add(new Region("18", "Region Autonoma Atlantico Sur"));
			countryList.Add(country);

			// Niger
			country = new Country("Niger", "NE");
			country.Regions.Add(new Region("01", "Agadez"));
			country.Regions.Add(new Region("02", "Diffa"));
			country.Regions.Add(new Region("03", "Dosso"));
			country.Regions.Add(new Region("04", "Maradi"));
			country.Regions.Add(new Region("05", "Niamey"));
			country.Regions.Add(new Region("06", "Tahoua"));
			country.Regions.Add(new Region("07", "Zinder"));
			country.Regions.Add(new Region("08", "Niamey"));
			countryList.Add(country);

			// Nigeria
			country = new Country("Nigeria", "NG");
			country.Regions.Add(new Region("05", "Lagos"));
			country.Regions.Add(new Region("11", "Federal Capital Territory"));
			country.Regions.Add(new Region("16", "Ogun"));
			country.Regions.Add(new Region("21", "Akwa Ibom"));
			country.Regions.Add(new Region("22", "Cross River"));
			country.Regions.Add(new Region("23", "Kaduna"));
			country.Regions.Add(new Region("24", "Katsina"));
			country.Regions.Add(new Region("25", "Anambra"));
			country.Regions.Add(new Region("26", "Benue"));
			country.Regions.Add(new Region("27", "Borno"));
			country.Regions.Add(new Region("28", "Imo"));
			country.Regions.Add(new Region("29", "Kano"));
			country.Regions.Add(new Region("30", "Kwara"));
			country.Regions.Add(new Region("31", "Niger"));
			country.Regions.Add(new Region("32", "Oyo"));
			country.Regions.Add(new Region("35", "Adamawa"));
			country.Regions.Add(new Region("36", "Delta"));
			country.Regions.Add(new Region("37", "Edo"));
			country.Regions.Add(new Region("39", "Jigawa"));
			country.Regions.Add(new Region("40", "Kebbi"));
			country.Regions.Add(new Region("41", "Kogi"));
			country.Regions.Add(new Region("42", "Osun"));
			country.Regions.Add(new Region("43", "Taraba"));
			country.Regions.Add(new Region("44", "Yobe"));
			country.Regions.Add(new Region("45", "Abia"));
			country.Regions.Add(new Region("46", "Bauchi"));
			country.Regions.Add(new Region("47", "Enugu"));
			country.Regions.Add(new Region("48", "Ondo"));
			country.Regions.Add(new Region("49", "Plateau"));
			country.Regions.Add(new Region("50", "Rivers"));
			country.Regions.Add(new Region("51", "Sokoto"));
			country.Regions.Add(new Region("52", "Bayelsa"));
			country.Regions.Add(new Region("53", "Ebonyi"));
			country.Regions.Add(new Region("54", "Ekiti"));
			country.Regions.Add(new Region("55", "Gombe"));
			country.Regions.Add(new Region("56", "Nassarawa"));
			country.Regions.Add(new Region("57", "Zamfara"));
			countryList.Add(country);

			// Niue -------------------------------------------------------------------
			country = new Country("Niue", "NU");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Norfolk Island -------------------------------------------------------------------
			//country = new Country("Norfolk Island", "NF");
			//countryList.Add(country);

			// Northern Mariana Islands -------------------------------------------------------------------
			country = new Country("Northern Mariana Islands", "MP");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Norway
			country = new Country("Norway", "NO");
			country.Regions.Add(new Region("01", "Akershus"));
			country.Regions.Add(new Region("02", "Aust-Agder"));
			country.Regions.Add(new Region("04", "Buskerud"));
			country.Regions.Add(new Region("05", "Finnmark"));
			country.Regions.Add(new Region("06", "Hedmark"));
			country.Regions.Add(new Region("07", "Hordaland"));
			country.Regions.Add(new Region("08", "More og Romsdal"));
			country.Regions.Add(new Region("09", "Nordland"));
			country.Regions.Add(new Region("10", "Nord-Trondelag"));
			country.Regions.Add(new Region("11", "Oppland"));
			country.Regions.Add(new Region("12", "Oslo"));
			country.Regions.Add(new Region("13", "Ostfold"));
			country.Regions.Add(new Region("14", "Rogaland"));
			country.Regions.Add(new Region("15", "Sogn og Fjordane"));
			country.Regions.Add(new Region("16", "Sor-Trondelag"));
			country.Regions.Add(new Region("17", "Telemark"));
			country.Regions.Add(new Region("18", "Troms"));
			country.Regions.Add(new Region("19", "Vest-Agder"));
			country.Regions.Add(new Region("20", "Vestfold"));
			countryList.Add(country);

			// Oman
			country = new Country("Oman", "OM");
			country.Regions.Add(new Region("01", "Ad Dakhiliyah"));
			country.Regions.Add(new Region("02", "Al Batinah"));
			country.Regions.Add(new Region("03", "Al Wusta"));
			country.Regions.Add(new Region("04", "Ash Sharqiyah"));
			country.Regions.Add(new Region("05", "Az Zahirah"));
			country.Regions.Add(new Region("06", "Masqat"));
			country.Regions.Add(new Region("07", "Musandam"));
			country.Regions.Add(new Region("08", "Zufar"));
			countryList.Add(country);

			// Pakistan
			country = new Country("Pakistan", "PK");
			country.Regions.Add(new Region("01", "Federally Administered Tribal Areas"));
			country.Regions.Add(new Region("02", "Balochistan"));
			country.Regions.Add(new Region("03", "North-West Frontier"));
			country.Regions.Add(new Region("04", "Punjab"));
			country.Regions.Add(new Region("05", "Sindh"));
			country.Regions.Add(new Region("06", "Azad Kashmir"));
			country.Regions.Add(new Region("07", "Northern Areas"));
			country.Regions.Add(new Region("08", "Islamabad"));
			countryList.Add(country);

			// Palau -------------------------------------------------------------------
			country = new Country("Palau", "PW");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Palestine
			country = new Country("Palestine", "PS");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Panama
			country = new Country("Panama", "PA");
			country.Regions.Add(new Region("01", "Bocas del Toro"));
			country.Regions.Add(new Region("02", "Chiriqui"));
			country.Regions.Add(new Region("03", "Cocle"));
			country.Regions.Add(new Region("04", "Colon"));
			country.Regions.Add(new Region("05", "Darien"));
			country.Regions.Add(new Region("06", "Herrera"));
			country.Regions.Add(new Region("07", "Los Santos"));
			country.Regions.Add(new Region("08", "Panama"));
			country.Regions.Add(new Region("09", "San Blas"));
			country.Regions.Add(new Region("10", "Veraguas"));
			countryList.Add(country);

			// Papau New Guinea
			country = new Country("Papau New Guinea", "PG");
			country.Regions.Add(new Region("01", "Central"));
			country.Regions.Add(new Region("02", "Gulf"));
			country.Regions.Add(new Region("03", "Milne Bay"));
			country.Regions.Add(new Region("04", "Northern"));
			country.Regions.Add(new Region("05", "Southern Highlands"));
			country.Regions.Add(new Region("06", "Western"));
			country.Regions.Add(new Region("07", "North Solomons"));
			country.Regions.Add(new Region("08", "Chimbu"));
			country.Regions.Add(new Region("09", "Eastern Highlands"));
			country.Regions.Add(new Region("10", "East New Britain"));
			country.Regions.Add(new Region("11", "East Sepik"));
			country.Regions.Add(new Region("12", "Madang"));
			country.Regions.Add(new Region("13", "Manus"));
			country.Regions.Add(new Region("14", "Morobe"));
			country.Regions.Add(new Region("15", "New Ireland"));
			country.Regions.Add(new Region("16", "Western Highlands"));
			country.Regions.Add(new Region("17", "West New Britain"));
			country.Regions.Add(new Region("18", "Sandaun"));
			country.Regions.Add(new Region("19", "Enga"));
			country.Regions.Add(new Region("20", "National Capital"));
			countryList.Add(country);

			// Paraguay
			country = new Country("Paraguay", "PY");
			country.Regions.Add(new Region("01", "Alto Parana"));
			country.Regions.Add(new Region("02", "Amambay"));
			country.Regions.Add(new Region("03", "Boqueron"));
			country.Regions.Add(new Region("04", "Caaguazu"));
			country.Regions.Add(new Region("05", "Caazapa"));
			country.Regions.Add(new Region("06", "Central"));
			country.Regions.Add(new Region("07", "Concepcion"));
			country.Regions.Add(new Region("08", "Cordillera"));
			country.Regions.Add(new Region("10", "Guaira"));
			country.Regions.Add(new Region("11", "Itapua"));
			country.Regions.Add(new Region("12", "Misiones"));
			country.Regions.Add(new Region("13", "Neembucu"));
			country.Regions.Add(new Region("15", "Paraguari"));
			country.Regions.Add(new Region("16", "Presidente Hayes"));
			country.Regions.Add(new Region("17", "San Pedro"));
			country.Regions.Add(new Region("19", "Canindeyu"));
			country.Regions.Add(new Region("20", "Chaco"));
			country.Regions.Add(new Region("21", "Nueva Asuncion"));
			country.Regions.Add(new Region("23", "Alto Paraguay"));
			countryList.Add(country);

			// Peru
			country = new Country("Peru", "PE");
			country.Regions.Add(new Region("01", "Amazonas"));
			country.Regions.Add(new Region("02", "Ancash"));
			country.Regions.Add(new Region("03", "Apurimac"));
			country.Regions.Add(new Region("04", "Arequipa"));
			country.Regions.Add(new Region("05", "Ayacucho"));
			country.Regions.Add(new Region("06", "Cajamarca"));
			country.Regions.Add(new Region("07", "Callao"));
			country.Regions.Add(new Region("08", "Cusco"));
			country.Regions.Add(new Region("09", "Huancavelica"));
			country.Regions.Add(new Region("10", "Huanuco"));
			country.Regions.Add(new Region("11", "Ica"));
			country.Regions.Add(new Region("12", "Junin"));
			country.Regions.Add(new Region("13", "La Libertad"));
			country.Regions.Add(new Region("14", "Lambayeque"));
			country.Regions.Add(new Region("15", "Lima"));
			country.Regions.Add(new Region("16", "Loreto"));
			country.Regions.Add(new Region("17", "Madre de Dios"));
			country.Regions.Add(new Region("18", "Moquegua"));
			country.Regions.Add(new Region("19", "Pasco"));
			country.Regions.Add(new Region("20", "Piura"));
			country.Regions.Add(new Region("21", "Puno"));
			country.Regions.Add(new Region("22", "San Martin"));
			country.Regions.Add(new Region("23", "Tacna"));
			country.Regions.Add(new Region("24", "Tumbes"));
			country.Regions.Add(new Region("25", "Ucayali"));
			countryList.Add(country);

			// Philippines
			country = new Country("Philippines", "PH");
			country.Regions.Add(new Region("01", "Abra"));
			country.Regions.Add(new Region("02", "Agusan del Norte"));
			country.Regions.Add(new Region("03", "Agusan del Sur"));
			country.Regions.Add(new Region("04", "Aklan"));
			country.Regions.Add(new Region("05", "Albay"));
			country.Regions.Add(new Region("06", "Antique"));
			country.Regions.Add(new Region("07", "Bataan"));
			country.Regions.Add(new Region("08", "Batanes"));
			country.Regions.Add(new Region("09", "Batangas"));
			country.Regions.Add(new Region("10", "Benguet"));
			country.Regions.Add(new Region("11", "Bohol"));
			country.Regions.Add(new Region("12", "Bukidnon"));
			country.Regions.Add(new Region("13", "Bulacan"));
			country.Regions.Add(new Region("14", "Cagayan"));
			country.Regions.Add(new Region("15", "Camarines Norte"));
			country.Regions.Add(new Region("16", "Camarines Sur"));
			country.Regions.Add(new Region("17", "Camiguin"));
			country.Regions.Add(new Region("18", "Capiz"));
			country.Regions.Add(new Region("19", "Catanduanes"));
			country.Regions.Add(new Region("20", "Cavite"));
			country.Regions.Add(new Region("21", "Cebu"));
			country.Regions.Add(new Region("22", "Basilan"));
			country.Regions.Add(new Region("23", "Eastern Samar"));
			country.Regions.Add(new Region("24", "Davao"));
			country.Regions.Add(new Region("25", "Davao del Sur"));
			country.Regions.Add(new Region("26", "Davao Oriental"));
			country.Regions.Add(new Region("27", "Ifugao"));
			country.Regions.Add(new Region("28", "Ilocos Norte"));
			country.Regions.Add(new Region("29", "Ilocos Sur"));
			country.Regions.Add(new Region("30", "Iloilo"));
			country.Regions.Add(new Region("31", "Isabela"));
			country.Regions.Add(new Region("32", "Kalinga-Apayao"));
			country.Regions.Add(new Region("33", "Laguna"));
			country.Regions.Add(new Region("34", "Lanao del Norte"));
			country.Regions.Add(new Region("35", "Lanao del Sur"));
			country.Regions.Add(new Region("36", "La Union"));
			country.Regions.Add(new Region("37", "Leyte"));
			country.Regions.Add(new Region("38", "Marinduque"));
			country.Regions.Add(new Region("39", "Masbate"));
			country.Regions.Add(new Region("40", "Mindoro Occidental"));
			country.Regions.Add(new Region("41", "Mindoro Oriental"));
			country.Regions.Add(new Region("42", "Misamis Occidental"));
			country.Regions.Add(new Region("43", "Misamis Oriental"));
			country.Regions.Add(new Region("44", "Mountain"));
			country.Regions.Add(new Region("45", "Negros Occidental"));
			country.Regions.Add(new Region("46", "Negros Oriental"));
			country.Regions.Add(new Region("47", "Nueva Ecija"));
			country.Regions.Add(new Region("48", "Nueva Vizcaya"));
			country.Regions.Add(new Region("49", "Palawan"));
			country.Regions.Add(new Region("50", "Pampanga"));
			country.Regions.Add(new Region("51", "Pangasinan"));
			country.Regions.Add(new Region("53", "Rizal"));
			country.Regions.Add(new Region("54", "Romblon"));
			country.Regions.Add(new Region("55", "Samar"));
			country.Regions.Add(new Region("56", "Maguindanao"));
			country.Regions.Add(new Region("57", "North Cotabato"));
			country.Regions.Add(new Region("58", "Sorsogon"));
			country.Regions.Add(new Region("59", "Southern Leyte"));
			country.Regions.Add(new Region("60", "Sulu"));
			country.Regions.Add(new Region("61", "Surigao del Norte"));
			country.Regions.Add(new Region("62", "Surigao del Sur"));
			country.Regions.Add(new Region("63", "Tarlac"));
			country.Regions.Add(new Region("64", "Zambales"));
			country.Regions.Add(new Region("65", "Zamboanga del Norte"));
			country.Regions.Add(new Region("66", "Zamboanga del Sur"));
			country.Regions.Add(new Region("67", "Northern Samar"));
			country.Regions.Add(new Region("68", "Quirino"));
			country.Regions.Add(new Region("69", "Siquijor"));
			country.Regions.Add(new Region("70", "South Cotabato"));
			country.Regions.Add(new Region("71", "Sultan Kudarat"));
			country.Regions.Add(new Region("72", "Tawitawi"));
			country.Regions.Add(new Region("A1", "Angeles"));
			country.Regions.Add(new Region("A2", "Bacolod"));
			country.Regions.Add(new Region("A3", "Bago"));
			country.Regions.Add(new Region("A4", "Baguio"));
			country.Regions.Add(new Region("A5", "Bais"));
			country.Regions.Add(new Region("A6", "Basilan City"));
			country.Regions.Add(new Region("A7", "Batangas City"));
			country.Regions.Add(new Region("A8", "Butuan"));
			country.Regions.Add(new Region("A9", "Cabanatuan"));
			country.Regions.Add(new Region("B1", "Cadiz"));
			country.Regions.Add(new Region("B2", "Cagayan de Oro"));
			country.Regions.Add(new Region("B3", "Calbayog"));
			country.Regions.Add(new Region("B4", "Caloocan"));
			country.Regions.Add(new Region("B5", "Canlaon"));
			country.Regions.Add(new Region("B6", "Cavite City"));
			country.Regions.Add(new Region("B7", "Cebu City"));
			country.Regions.Add(new Region("B8", "Cotabato"));
			country.Regions.Add(new Region("B9", "Dagupan"));
			country.Regions.Add(new Region("C1", "Danao"));
			country.Regions.Add(new Region("C2", "Dapitan"));
			country.Regions.Add(new Region("C3", "Davao City"));
			country.Regions.Add(new Region("C4", "Dipolog"));
			country.Regions.Add(new Region("C5", "Dumaguete"));
			country.Regions.Add(new Region("C6", "General Santos"));
			country.Regions.Add(new Region("C7", "Gingoog"));
			country.Regions.Add(new Region("C8", "Iligan"));
			country.Regions.Add(new Region("C9", "Iloilo City"));
			country.Regions.Add(new Region("D1", "Iriga"));
			country.Regions.Add(new Region("D2", "La Carlota"));
			country.Regions.Add(new Region("D3", "Laoag"));
			country.Regions.Add(new Region("D4", "Lapu-Lapu"));
			country.Regions.Add(new Region("D5", "Legaspi"));
			country.Regions.Add(new Region("D6", "Lipa"));
			country.Regions.Add(new Region("D7", "Lucena"));
			country.Regions.Add(new Region("D8", "Mandaue"));
			country.Regions.Add(new Region("D9", "Manila"));
			country.Regions.Add(new Region("E1", "Marawi"));
			country.Regions.Add(new Region("E2", "Naga"));
			country.Regions.Add(new Region("E3", "Olongapo"));
			country.Regions.Add(new Region("E4", "Ormoc"));
			country.Regions.Add(new Region("E5", "Oroquieta"));
			country.Regions.Add(new Region("E6", "Ozamis"));
			country.Regions.Add(new Region("E7", "Pagadian"));
			country.Regions.Add(new Region("E8", "Palayan"));
			country.Regions.Add(new Region("E9", "Pasay"));
			country.Regions.Add(new Region("F1", "Puerto Princesa"));
			country.Regions.Add(new Region("F2", "Quezon City"));
			country.Regions.Add(new Region("F3", "Roxas"));
			country.Regions.Add(new Region("F4", "San Carlos"));
			country.Regions.Add(new Region("F5", "San Carlos"));
			country.Regions.Add(new Region("F6", "San Jose"));
			country.Regions.Add(new Region("F7", "San Pablo"));
			country.Regions.Add(new Region("F8", "Silay"));
			country.Regions.Add(new Region("F9", "Surigao"));
			country.Regions.Add(new Region("G1", "Tacloban"));
			country.Regions.Add(new Region("G2", "Tagaytay"));
			country.Regions.Add(new Region("G3", "Tagbilaran"));
			country.Regions.Add(new Region("G4", "Tangub"));
			country.Regions.Add(new Region("G5", "Toledo"));
			country.Regions.Add(new Region("G6", "Trece Martires"));
			country.Regions.Add(new Region("G7", "Zamboanga"));
			country.Regions.Add(new Region("G8", "Aurora"));
			country.Regions.Add(new Region("H2", "Quezon"));
			country.Regions.Add(new Region("H3", "Negros Occidental"));
			country.Regions.Add(new Region("I6", "Compostela Valley"));
			country.Regions.Add(new Region("I7", "Davao del Norte"));
			country.Regions.Add(new Region("J7", "Kalinga"));
			country.Regions.Add(new Region("K6", "Malaybalay"));
			country.Regions.Add(new Region("M5", "San Jose del Monte"));
			country.Regions.Add(new Region("M6", "San Juan"));
			country.Regions.Add(new Region("M8", "Santiago"));
			country.Regions.Add(new Region("M9", "Sarangani"));
			country.Regions.Add(new Region("N1", "Sipalay"));
			country.Regions.Add(new Region("N3", "Surigao del Norte"));
			country.Regions.Add(new Region("P1", "Zambales"));
			country.Regions.Add(new Region("P2", "Zamboanga"));
			countryList.Add(country);

			// Poland
			country = new Country("Poland", "PL");
			country.Regions.Add(new Region("72", "Dolnoslaskie"));
			country.Regions.Add(new Region("73", "Kujawsko-Pomorskie"));
			country.Regions.Add(new Region("74", "Lodzkie"));
			country.Regions.Add(new Region("75", "Lubelskie"));
			country.Regions.Add(new Region("76", "Lubuskie"));
			country.Regions.Add(new Region("77", "Malopolskie"));
			country.Regions.Add(new Region("78", "Mazowieckie"));
			country.Regions.Add(new Region("79", "Opolskie"));
			country.Regions.Add(new Region("80", "Podkarpackie"));
			country.Regions.Add(new Region("81", "Podlaskie"));
			country.Regions.Add(new Region("82", "Pomorskie"));
			country.Regions.Add(new Region("83", "Slaskie"));
			country.Regions.Add(new Region("84", "Swietokrzyskie"));
			country.Regions.Add(new Region("85", "Warminsko-Mazurskie"));
			country.Regions.Add(new Region("86", "Wielkopolskie"));
			country.Regions.Add(new Region("87", "Zachodniopomorskie"));
			countryList.Add(country);

			// Pitcairn -------------------------------------------------------------------
			country = new Country("Pitcairn", "PN");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Portugal
			country = new Country("Portugal", "PT");
			country.Regions.Add(new Region("02", "Aveiro"));
			country.Regions.Add(new Region("03", "Beja"));
			country.Regions.Add(new Region("04", "Braga"));
			country.Regions.Add(new Region("05", "Braganca"));
			country.Regions.Add(new Region("06", "Castelo Branco"));
			country.Regions.Add(new Region("07", "Coimbra"));
			country.Regions.Add(new Region("08", "Evora"));
			country.Regions.Add(new Region("09", "Faro"));
			country.Regions.Add(new Region("10", "Madeira"));
			country.Regions.Add(new Region("11", "Guarda"));
			country.Regions.Add(new Region("13", "Leiria"));
			country.Regions.Add(new Region("14", "Lisboa"));
			country.Regions.Add(new Region("16", "Portalegre"));
			country.Regions.Add(new Region("17", "Porto"));
			country.Regions.Add(new Region("18", "Santarem"));
			country.Regions.Add(new Region("19", "Setubal"));
			country.Regions.Add(new Region("20", "Viana do Castelo"));
			country.Regions.Add(new Region("21", "Vila Real"));
			country.Regions.Add(new Region("22", "Viseu"));
			country.Regions.Add(new Region("23", "Azores"));
			countryList.Add(country);

			// Puerto Rico -------------------------------------------------------------------
			country = new Country("Puerto Rico", "PR");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Qatar
			country = new Country("Qatar", "QA");
			country.Regions.Add(new Region("01", "Ad Dawhah"));
			country.Regions.Add(new Region("02", "Al Ghuwariyah"));
			country.Regions.Add(new Region("03", "Al Jumaliyah"));
			country.Regions.Add(new Region("04", "Al Khawr"));
			country.Regions.Add(new Region("05", "Al Wakrah Municipality"));
			country.Regions.Add(new Region("06", "Ar Rayyan"));
			country.Regions.Add(new Region("08", "Madinat ach Shamal"));
			country.Regions.Add(new Region("09", "Umm Salal"));
			country.Regions.Add(new Region("10", "Al Wakrah"));
			country.Regions.Add(new Region("11", "Jariyan al Batnah"));
			country.Regions.Add(new Region("12", "Umm Sa'id"));
			countryList.Add(country);

			// Reunion -------------------------------------------------------------------
			country = new Country("Reunion", "RE");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Romania
			country = new Country("Romania", "RO");
			country.Regions.Add(new Region("01", "Alba"));
			country.Regions.Add(new Region("02", "Arad"));
			country.Regions.Add(new Region("03", "Arges"));
			country.Regions.Add(new Region("04", "Bacau"));
			country.Regions.Add(new Region("05", "Bihor"));
			country.Regions.Add(new Region("06", "Bistrita-Nasaud"));
			country.Regions.Add(new Region("07", "Botosani"));
			country.Regions.Add(new Region("08", "Braila"));
			country.Regions.Add(new Region("09", "Brasov"));
			country.Regions.Add(new Region("10", "Bucuresti"));
			country.Regions.Add(new Region("11", "Buzau"));
			country.Regions.Add(new Region("12", "Caras-Severin"));
			country.Regions.Add(new Region("13", "Cluj"));
			country.Regions.Add(new Region("14", "Constanta"));
			country.Regions.Add(new Region("15", "Covasna"));
			country.Regions.Add(new Region("16", "Dambovita"));
			country.Regions.Add(new Region("17", "Dolj"));
			country.Regions.Add(new Region("18", "Galati"));
			country.Regions.Add(new Region("19", "Gorj"));
			country.Regions.Add(new Region("20", "Harghita"));
			country.Regions.Add(new Region("21", "Hunedoara"));
			country.Regions.Add(new Region("22", "Ialomita"));
			country.Regions.Add(new Region("23", "Iasi"));
			country.Regions.Add(new Region("25", "Maramures"));
			country.Regions.Add(new Region("26", "Mehedinti"));
			country.Regions.Add(new Region("27", "Mures"));
			country.Regions.Add(new Region("28", "Neamt"));
			country.Regions.Add(new Region("29", "Olt"));
			country.Regions.Add(new Region("30", "Prahova"));
			country.Regions.Add(new Region("31", "Salaj"));
			country.Regions.Add(new Region("32", "Satu Mare"));
			country.Regions.Add(new Region("33", "Sibiu"));
			country.Regions.Add(new Region("34", "Suceava"));
			country.Regions.Add(new Region("35", "Teleorman"));
			country.Regions.Add(new Region("36", "Timis"));
			country.Regions.Add(new Region("37", "Tulcea"));
			country.Regions.Add(new Region("38", "Vaslui"));
			country.Regions.Add(new Region("39", "Valcea"));
			country.Regions.Add(new Region("40", "Vrancea"));
			country.Regions.Add(new Region("41", "Calarasi"));
			country.Regions.Add(new Region("42", "Giurgiu"));
			country.Regions.Add(new Region("43", "Ilfov"));
			countryList.Add(country);

			// Russian Federation
			country = new Country("Russian Federation", "RU");
			country.Regions.Add(new Region("01", "Adygeya)); Republic of"));
			country.Regions.Add(new Region("02", "Aginsky Buryatsky AO"));
			country.Regions.Add(new Region("03", "Gorno-Altay"));
			country.Regions.Add(new Region("04", "Altaisky krai"));
			country.Regions.Add(new Region("05", "Amur"));
			country.Regions.Add(new Region("06", "Arkhangel'sk"));
			country.Regions.Add(new Region("07", "Astrakhan'"));
			country.Regions.Add(new Region("08", "Bashkortostan"));
			country.Regions.Add(new Region("09", "Belgorod"));
			country.Regions.Add(new Region("10", "Bryansk"));
			country.Regions.Add(new Region("11", "Buryat"));
			country.Regions.Add(new Region("12", "Chechnya"));
			country.Regions.Add(new Region("13", "Chelyabinsk"));
			country.Regions.Add(new Region("14", "Chita"));
			country.Regions.Add(new Region("15", "Chukot"));
			country.Regions.Add(new Region("16", "Chuvashia"));
			country.Regions.Add(new Region("17", "Dagestan"));
			country.Regions.Add(new Region("18", "Evenk"));
			country.Regions.Add(new Region("19", "Ingush"));
			country.Regions.Add(new Region("20", "Irkutsk"));
			country.Regions.Add(new Region("21", "Ivanovo"));
			country.Regions.Add(new Region("22", "Kabardin-Balkar"));
			country.Regions.Add(new Region("23", "Kaliningrad"));
			country.Regions.Add(new Region("24", "Kalmyk"));
			country.Regions.Add(new Region("25", "Kaluga"));
			country.Regions.Add(new Region("26", "Kamchatka"));
			country.Regions.Add(new Region("27", "Karachay-Cherkess"));
			country.Regions.Add(new Region("28", "Karelia"));
			country.Regions.Add(new Region("29", "Kemerovo"));
			country.Regions.Add(new Region("30", "Khabarovsk"));
			country.Regions.Add(new Region("31", "Khakass"));
			country.Regions.Add(new Region("32", "Khanty-Mansiy"));
			country.Regions.Add(new Region("33", "Kirov"));
			country.Regions.Add(new Region("34", "Komi"));
			country.Regions.Add(new Region("35", "Komi-Permyak"));
			country.Regions.Add(new Region("36", "Koryak"));
			country.Regions.Add(new Region("37", "Kostroma"));
			country.Regions.Add(new Region("38", "Krasnodar"));
			country.Regions.Add(new Region("39", "Krasnoyarsk"));
			country.Regions.Add(new Region("40", "Kurgan"));
			country.Regions.Add(new Region("41", "Kursk"));
			country.Regions.Add(new Region("42", "Leningrad"));
			country.Regions.Add(new Region("43", "Lipetsk"));
			country.Regions.Add(new Region("44", "Magadan"));
			country.Regions.Add(new Region("45", "Mariy-El"));
			country.Regions.Add(new Region("46", "Mordovia"));
			country.Regions.Add(new Region("47", "Moskva"));
			country.Regions.Add(new Region("48", "Moscow City"));
			country.Regions.Add(new Region("49", "Murmansk"));
			country.Regions.Add(new Region("50", "Nenets"));
			country.Regions.Add(new Region("51", "Nizhegorod"));
			country.Regions.Add(new Region("52", "Novgorod"));
			country.Regions.Add(new Region("53", "Novosibirsk"));
			country.Regions.Add(new Region("54", "Omsk"));
			country.Regions.Add(new Region("55", "Orenburg"));
			country.Regions.Add(new Region("56", "Orel"));
			country.Regions.Add(new Region("57", "Penza"));
			country.Regions.Add(new Region("58", "Perm'"));
			country.Regions.Add(new Region("59", "Primor'ye"));
			country.Regions.Add(new Region("60", "Pskov"));
			country.Regions.Add(new Region("61", "Rostov"));
			country.Regions.Add(new Region("62", "Ryazan'"));
			country.Regions.Add(new Region("63", "Sakha"));
			country.Regions.Add(new Region("64", "Sakhalin"));
			country.Regions.Add(new Region("65", "Samara"));
			country.Regions.Add(new Region("66", "Saint Petersburg City"));
			country.Regions.Add(new Region("67", "Saratov"));
			country.Regions.Add(new Region("68", "North Ossetia"));
			country.Regions.Add(new Region("69", "Smolensk"));
			country.Regions.Add(new Region("70", "Stavropol'"));
			country.Regions.Add(new Region("71", "Sverdlovsk"));
			country.Regions.Add(new Region("72", "Tambovskaya oblast"));
			country.Regions.Add(new Region("73", "Tatarstan"));
			country.Regions.Add(new Region("74", "Taymyr"));
			country.Regions.Add(new Region("75", "Tomsk"));
			country.Regions.Add(new Region("76", "Tula"));
			country.Regions.Add(new Region("77", "Tver'"));
			country.Regions.Add(new Region("78", "Tyumen'"));
			country.Regions.Add(new Region("79", "Tuva"));
			country.Regions.Add(new Region("80", "Udmurt"));
			country.Regions.Add(new Region("81", "Ul'yanovsk"));
			country.Regions.Add(new Region("82", "Ust-Orda Buryat"));
			country.Regions.Add(new Region("83", "Vladimir"));
			country.Regions.Add(new Region("84", "Volgograd"));
			country.Regions.Add(new Region("85", "Vologda"));
			country.Regions.Add(new Region("86", "Voronezh"));
			country.Regions.Add(new Region("87", "Yamal-Nenets"));
			country.Regions.Add(new Region("88", "Yaroslavl'"));
			country.Regions.Add(new Region("89", "Yevrey"));
			country.Regions.Add(new Region("90", "Permskiy Kray"));
			country.Regions.Add(new Region("91", "Krasnoyarskiy Kray"));
			country.Regions.Add(new Region("92", "Kamchatskiy Kray"));
			country.Regions.Add(new Region("93", "Zabaykal'skiy Kray"));
			countryList.Add(country);

			// Rwanda
			country = new Country("Rwanda", "RW");
			country.Regions.Add(new Region("01", "Butare"));
			country.Regions.Add(new Region("06", "Gitarama"));
			country.Regions.Add(new Region("07", "Kibungo"));
			country.Regions.Add(new Region("09", "Kigali"));
			country.Regions.Add(new Region("11", "Est"));
			country.Regions.Add(new Region("12", "Kigali"));
			country.Regions.Add(new Region("13", "Nord"));
			country.Regions.Add(new Region("14", "Ouest"));
			country.Regions.Add(new Region("15", "Sud"));
			countryList.Add(country);

			// Saint Kitts and Nevis
			country = new Country("Saint Kitts and Nevis", "KN");
			country.Regions.Add(new Region("01", "Christ Church Nichola Town"));
			country.Regions.Add(new Region("02", "Saint Anne Sandy Point"));
			country.Regions.Add(new Region("03", "Saint George Basseterre"));
			country.Regions.Add(new Region("04", "Saint George Gingerland"));
			country.Regions.Add(new Region("05", "Saint James Windward"));
			country.Regions.Add(new Region("06", "Saint John Capisterre"));
			country.Regions.Add(new Region("07", "Saint John Figtree"));
			country.Regions.Add(new Region("08", "Saint Mary Cayon"));
			country.Regions.Add(new Region("09", "Saint Paul Capisterre"));
			country.Regions.Add(new Region("10", "Saint Paul Charlestown"));
			country.Regions.Add(new Region("11", "Saint Peter Basseterre"));
			country.Regions.Add(new Region("12", "Saint Thomas Lowland"));
			country.Regions.Add(new Region("13", "Saint Thomas Middle Island"));
			country.Regions.Add(new Region("15", "Trinity Palmetto Point"));
			countryList.Add(country);

			// Saint Lucia
			country = new Country("Saint Lucia", "LC");
			country.Regions.Add(new Region("01", "Anse-la-Raye"));
			country.Regions.Add(new Region("02", "Dauphin"));
			country.Regions.Add(new Region("03", "Castries"));
			country.Regions.Add(new Region("04", "Choiseul"));
			country.Regions.Add(new Region("05", "Dennery"));
			country.Regions.Add(new Region("06", "Gros-Islet"));
			country.Regions.Add(new Region("07", "Laborie"));
			country.Regions.Add(new Region("08", "Micoud"));
			country.Regions.Add(new Region("09", "Soufriere"));
			country.Regions.Add(new Region("10", "Vieux-Fort"));
			country.Regions.Add(new Region("11", "Praslin"));
			countryList.Add(country);

			// Saint Vincent and The Grenadines
			country = new Country("Saint Vincent and The Grenadines", "VC");
			country.Regions.Add(new Region("01", "Charlotte"));
			country.Regions.Add(new Region("02", "Saint Andrew"));
			country.Regions.Add(new Region("03", "Saint David"));
			country.Regions.Add(new Region("04", "Saint George"));
			country.Regions.Add(new Region("05", "Saint Patrick"));
			country.Regions.Add(new Region("06", "Grenadines"));
			countryList.Add(country);

			// Samoa
			country = new Country("Samoa", "WS");
			country.Regions.Add(new Region("02", "Aiga-i-le-Tai"));
			country.Regions.Add(new Region("03", "Atua"));
			country.Regions.Add(new Region("04", "Fa"));
			country.Regions.Add(new Region("05", "Gaga"));
			country.Regions.Add(new Region("06", "Va"));
			country.Regions.Add(new Region("07", "Gagaifomauga"));
			country.Regions.Add(new Region("08", "Palauli"));
			country.Regions.Add(new Region("09", "Satupa"));
			country.Regions.Add(new Region("10", "Tuamasaga"));
			country.Regions.Add(new Region("11", "Vaisigano"));
			countryList.Add(country);

			// San Marino
			country = new Country("San Marino", "SM");
			country.Regions.Add(new Region("01", "Acquaviva"));
			country.Regions.Add(new Region("02", "Chiesanuova"));
			country.Regions.Add(new Region("03", "Domagnano"));
			country.Regions.Add(new Region("04", "Faetano"));
			country.Regions.Add(new Region("05", "Fiorentino"));
			country.Regions.Add(new Region("06", "Borgo Maggiore"));
			country.Regions.Add(new Region("07", "San Marino"));
			country.Regions.Add(new Region("08", "Monte Giardino"));
			country.Regions.Add(new Region("09", "Serravalle"));
			countryList.Add(country);

			// Sao Tome and Principe
			country = new Country("Sao Tome and Principe", "ST");
			country.Regions.Add(new Region("01", "Principe"));
			country.Regions.Add(new Region("02", "Sao Tome"));
			countryList.Add(country);

			// Saudi Arabia
			country = new Country("Saudi Arabia", "SA");
			country.Regions.Add(new Region("02", "Al Bahah"));
			country.Regions.Add(new Region("05", "Al Madinah"));
			country.Regions.Add(new Region("06", "Ash Sharqiyah"));
			country.Regions.Add(new Region("08", "Al Qasim"));
			country.Regions.Add(new Region("10", "Ar Riyad"));
			country.Regions.Add(new Region("11", "Asir Province"));
			country.Regions.Add(new Region("13", "Ha'il"));
			country.Regions.Add(new Region("14", "Makkah"));
			country.Regions.Add(new Region("15", "Al Hudud ash Shamaliyah"));
			country.Regions.Add(new Region("16", "Najran"));
			country.Regions.Add(new Region("17", "Jizan"));
			country.Regions.Add(new Region("19", "Tabuk"));
			country.Regions.Add(new Region("20", "Al Jawf"));
			countryList.Add(country);

			// Senegal
			country = new Country("Senegal", "SN");
			country.Regions.Add(new Region("01", "Dakar"));
			country.Regions.Add(new Region("03", "Diourbel"));
			country.Regions.Add(new Region("05", "Tambacounda"));
			country.Regions.Add(new Region("07", "Thies"));
			country.Regions.Add(new Region("09", "Fatick"));
			country.Regions.Add(new Region("10", "Kaolack"));
			country.Regions.Add(new Region("11", "Kolda"));
			country.Regions.Add(new Region("12", "Ziguinchor"));
			country.Regions.Add(new Region("13", "Louga"));
			country.Regions.Add(new Region("14", "Saint-Louis"));
			country.Regions.Add(new Region("15", "Matam"));
			countryList.Add(country);

			// Seychelles
			country = new Country("Seychelles", "SC");
			country.Regions.Add(new Region("01", "Anse aux Pins"));
			country.Regions.Add(new Region("02", "Anse Boileau"));
			country.Regions.Add(new Region("03", "Anse Etoile"));
			country.Regions.Add(new Region("04", "Anse Louis"));
			country.Regions.Add(new Region("05", "Anse Royale"));
			country.Regions.Add(new Region("06", "Baie Lazare"));
			country.Regions.Add(new Region("07", "Baie Sainte Anne"));
			country.Regions.Add(new Region("08", "Beau Vallon"));
			country.Regions.Add(new Region("09", "Bel Air"));
			country.Regions.Add(new Region("10", "Bel Ombre"));
			country.Regions.Add(new Region("11", "Cascade"));
			country.Regions.Add(new Region("12", "Glacis"));
			country.Regions.Add(new Region("13", "Grand' Anse"));
			country.Regions.Add(new Region("14", "Grand' Anse"));
			country.Regions.Add(new Region("15", "La Digue"));
			country.Regions.Add(new Region("16", "La Riviere Anglaise"));
			country.Regions.Add(new Region("17", "Mont Buxton"));
			country.Regions.Add(new Region("18", "Mont Fleuri"));
			country.Regions.Add(new Region("19", "Plaisance"));
			country.Regions.Add(new Region("20", "Pointe La Rue"));
			country.Regions.Add(new Region("21", "Port Glaud"));
			country.Regions.Add(new Region("22", "Saint Louis"));
			country.Regions.Add(new Region("23", "Takamaka"));
			countryList.Add(country);

			// Sierra Leone
			country = new Country("Sierra Leone", "SL");
			country.Regions.Add(new Region("01", "Eastern"));
			country.Regions.Add(new Region("02", "Northern"));
			country.Regions.Add(new Region("03", "Southern"));
			country.Regions.Add(new Region("04", "Western Area"));
			countryList.Add(country);

			// Singapore -------------------------------------------------------------------
			country = new Country("Singapore", "SG");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Slovak Republic
			country = new Country("Slovak Republic", "SK");
			country.Regions.Add(new Region("01", "Banska Bystrica"));
			country.Regions.Add(new Region("02", "Bratislava"));
			country.Regions.Add(new Region("03", "Kosice"));
			country.Regions.Add(new Region("04", "Nitra"));
			country.Regions.Add(new Region("05", "Presov"));
			country.Regions.Add(new Region("06", "Trencin"));
			country.Regions.Add(new Region("07", "Trnava"));
			country.Regions.Add(new Region("08", "Zilina"));
			countryList.Add(country);

			// Slovenia
			country = new Country("Slovenia", "SI");
			country.Regions.Add(new Region("01", "Ajdovscina Commune"));
			country.Regions.Add(new Region("02", "Beltinci Commune"));
			country.Regions.Add(new Region("03", "Bled Commune"));
			country.Regions.Add(new Region("04", "Bohinj Commune"));
			country.Regions.Add(new Region("05", "Borovnica Commune"));
			country.Regions.Add(new Region("06", "Bovec Commune"));
			country.Regions.Add(new Region("07", "Brda Commune"));
			country.Regions.Add(new Region("08", "Brezice Commune"));
			country.Regions.Add(new Region("09", "Brezovica Commune"));
			country.Regions.Add(new Region("11", "Celje Commune"));
			country.Regions.Add(new Region("12", "Cerklje na Gorenjskem Commune"));
			country.Regions.Add(new Region("13", "Cerknica Commune"));
			country.Regions.Add(new Region("14", "Cerkno Commune"));
			country.Regions.Add(new Region("15", "Crensovci Commune"));
			country.Regions.Add(new Region("16", "Crna na Koroskem Commune"));
			country.Regions.Add(new Region("17", "Crnomelj Commune"));
			country.Regions.Add(new Region("19", "Divaca Commune"));
			country.Regions.Add(new Region("20", "Dobrepolje Commune"));
			country.Regions.Add(new Region("22", "Dol pri Ljubljani Commune"));
			country.Regions.Add(new Region("24", "Dornava Commune"));
			country.Regions.Add(new Region("25", "Dravograd Commune"));
			country.Regions.Add(new Region("26", "Duplek Commune"));
			country.Regions.Add(new Region("27", "Gorenja vas-Poljane Commune"));
			country.Regions.Add(new Region("28", "Gorisnica Commune"));
			country.Regions.Add(new Region("29", "Gornja Radgona Commune"));
			country.Regions.Add(new Region("30", "Gornji Grad Commune"));
			country.Regions.Add(new Region("31", "Gornji Petrovci Commune"));
			country.Regions.Add(new Region("32", "Grosuplje Commune"));
			country.Regions.Add(new Region("34", "Hrastnik Commune"));
			country.Regions.Add(new Region("35", "Hrpelje-Kozina Commune"));
			country.Regions.Add(new Region("36", "Idrija Commune"));
			country.Regions.Add(new Region("37", "Ig Commune"));
			country.Regions.Add(new Region("38", "Ilirska Bistrica Commune"));
			country.Regions.Add(new Region("39", "Ivancna Gorica Commune"));
			country.Regions.Add(new Region("40", "Izola-Isola Commune"));
			country.Regions.Add(new Region("42", "Jursinci Commune"));
			country.Regions.Add(new Region("44", "Kanal Commune"));
			country.Regions.Add(new Region("45", "Kidricevo Commune"));
			country.Regions.Add(new Region("46", "Kobarid Commune"));
			country.Regions.Add(new Region("47", "Kobilje Commune"));
			country.Regions.Add(new Region("49", "Komen Commune"));
			country.Regions.Add(new Region("50", "Koper-Capodistria Urban Commune"));
			country.Regions.Add(new Region("51", "Kozje Commune"));
			country.Regions.Add(new Region("52", "Kranj Commune"));
			country.Regions.Add(new Region("53", "Kranjska Gora Commune"));
			country.Regions.Add(new Region("54", "Krsko Commune"));
			country.Regions.Add(new Region("55", "Kungota Commune"));
			country.Regions.Add(new Region("57", "Lasko Commune"));
			country.Regions.Add(new Region("61", "Ljubljana Urban Commune"));
			country.Regions.Add(new Region("62", "Ljubno Commune"));
			country.Regions.Add(new Region("64", "Logatec Commune"));
			country.Regions.Add(new Region("66", "Loski Potok Commune"));
			country.Regions.Add(new Region("68", "Lukovica Commune"));
			country.Regions.Add(new Region("71", "Medvode Commune"));
			country.Regions.Add(new Region("72", "Menges Commune"));
			country.Regions.Add(new Region("73", "Metlika Commune"));
			country.Regions.Add(new Region("74", "Mezica Commune"));
			country.Regions.Add(new Region("76", "Mislinja Commune"));
			country.Regions.Add(new Region("77", "Moravce Commune"));
			country.Regions.Add(new Region("78", "Moravske Toplice Commune"));
			country.Regions.Add(new Region("79", "Mozirje Commune"));
			country.Regions.Add(new Region("80", "Murska Sobota Urban Commune"));
			country.Regions.Add(new Region("81", "Muta Commune"));
			country.Regions.Add(new Region("82", "Naklo Commune"));
			country.Regions.Add(new Region("83", "Nazarje Commune"));
			country.Regions.Add(new Region("84", "Nova Gorica Urban Commune"));
			country.Regions.Add(new Region("86", "Odranci Commune"));
			country.Regions.Add(new Region("87", "Ormoz Commune"));
			country.Regions.Add(new Region("88", "Osilnica Commune"));
			country.Regions.Add(new Region("89", "Pesnica Commune"));
			country.Regions.Add(new Region("91", "Pivka Commune"));
			country.Regions.Add(new Region("92", "Podcetrtek Commune"));
			country.Regions.Add(new Region("94", "Postojna Commune"));
			country.Regions.Add(new Region("97", "Puconci Commune"));
			country.Regions.Add(new Region("98", "Race-Fram Commune"));
			country.Regions.Add(new Region("99", "Radece Commune"));
			country.Regions.Add(new Region("A1", "Radenci Commune"));
			country.Regions.Add(new Region("A2", "Radlje ob Dravi Commune"));
			country.Regions.Add(new Region("A3", "Radovljica Commune"));
			country.Regions.Add(new Region("A6", "Rogasovci Commune"));
			country.Regions.Add(new Region("A7", "Rogaska Slatina Commune"));
			country.Regions.Add(new Region("A8", "Rogatec Commune"));
			country.Regions.Add(new Region("B1", "Semic Commune"));
			country.Regions.Add(new Region("B2", "Sencur Commune"));
			country.Regions.Add(new Region("B3", "Sentilj Commune"));
			country.Regions.Add(new Region("B4", "Sentjernej Commune"));
			country.Regions.Add(new Region("B6", "Sevnica Commune"));
			country.Regions.Add(new Region("B7", "Sezana Commune"));
			country.Regions.Add(new Region("B8", "Skocjan Commune"));
			country.Regions.Add(new Region("B9", "Skofja Loka Commune"));
			country.Regions.Add(new Region("C1", "Skofljica Commune"));
			country.Regions.Add(new Region("C2", "Slovenj Gradec Urban Commune"));
			country.Regions.Add(new Region("C4", "Slovenske Konjice Commune"));
			country.Regions.Add(new Region("C5", "Smarje pri Jelsah Commune"));
			country.Regions.Add(new Region("C6", "Smartno ob Paki Commune"));
			country.Regions.Add(new Region("C7", "Sostanj Commune"));
			country.Regions.Add(new Region("C8", "Starse Commune"));
			country.Regions.Add(new Region("C9", "Store Commune"));
			country.Regions.Add(new Region("D1", "Sveti Jurij Commune"));
			country.Regions.Add(new Region("D2", "Tolmin Commune"));
			country.Regions.Add(new Region("D3", "Trbovlje Commune"));
			country.Regions.Add(new Region("D4", "Trebnje Commune"));
			country.Regions.Add(new Region("D5", "Trzic Commune"));
			country.Regions.Add(new Region("D6", "Turnisce Commune"));
			country.Regions.Add(new Region("D7", "Velenje Urban Commune"));
			country.Regions.Add(new Region("D8", "Velike Lasce Commune"));
			country.Regions.Add(new Region("E1", "Vipava Commune"));
			country.Regions.Add(new Region("E2", "Vitanje Commune"));
			country.Regions.Add(new Region("E3", "Vodice Commune"));
			country.Regions.Add(new Region("E5", "Vrhnika Commune"));
			country.Regions.Add(new Region("E6", "Vuzenica Commune"));
			country.Regions.Add(new Region("E7", "Zagorje ob Savi Commune"));
			country.Regions.Add(new Region("E9", "Zavrc Commune"));
			country.Regions.Add(new Region("F1", "Zelezniki Commune"));
			country.Regions.Add(new Region("F2", "Ziri Commune"));
			country.Regions.Add(new Region("F3", "Zrece Commune"));
			country.Regions.Add(new Region("F4", "Benedikt Commune"));
			country.Regions.Add(new Region("F5", "Bistrica ob Sotli Commune"));
			country.Regions.Add(new Region("F6", "Bloke Commune"));
			country.Regions.Add(new Region("F7", "Braslovce Commune"));
			country.Regions.Add(new Region("F8", "Cankova Commune"));
			country.Regions.Add(new Region("F9", "Cerkvenjak Commune"));
			country.Regions.Add(new Region("G1", "Destrnik Commune"));
			country.Regions.Add(new Region("G2", "Dobje Commune"));
			country.Regions.Add(new Region("G3", "Dobrna Commune"));
			country.Regions.Add(new Region("G4", "Dobrova-Horjul-Polhov Gradec Commune"));
			country.Regions.Add(new Region("G5", "Dobrovnik-Dobronak Commune"));
			country.Regions.Add(new Region("G6", "Dolenjske Toplice Commune"));
			country.Regions.Add(new Region("G7", "Domzale Commune"));
			country.Regions.Add(new Region("G8", "Grad Commune"));
			country.Regions.Add(new Region("G9", "Hajdina Commune"));
			country.Regions.Add(new Region("H1", "Hoce-Slivnica Commune"));
			country.Regions.Add(new Region("H2", "Hodos-Hodos Commune"));
			country.Regions.Add(new Region("H3", "Horjul Commune"));
			country.Regions.Add(new Region("H4", "Jesenice Commune"));
			country.Regions.Add(new Region("H5", "Jezersko Commune"));
			country.Regions.Add(new Region("H6", "Kamnik Commune"));
			country.Regions.Add(new Region("H7", "Kocevje Commune"));
			country.Regions.Add(new Region("H8", "Komenda Commune"));
			country.Regions.Add(new Region("H9", "Kostel Commune"));
			country.Regions.Add(new Region("I1", "Krizevci Commune"));
			country.Regions.Add(new Region("I2", "Kuzma Commune"));
			country.Regions.Add(new Region("I3", "Lenart Commune"));
			country.Regions.Add(new Region("I4", "Lendava-Lendva Commune"));
			country.Regions.Add(new Region("I5", "Litija Commune"));
			country.Regions.Add(new Region("I6", "Ljutomer Commune"));
			country.Regions.Add(new Region("I7", "Loska Dolina Commune"));
			country.Regions.Add(new Region("I8", "Lovrenc na Pohorju Commune"));
			country.Regions.Add(new Region("I9", "Luce Commune"));
			country.Regions.Add(new Region("J1", "Majsperk Commune"));
			country.Regions.Add(new Region("J2", "Maribor Commune"));
			country.Regions.Add(new Region("J3", "Markovci Commune"));
			country.Regions.Add(new Region("J4", "Miklavz na Dravskem polju Commune"));
			country.Regions.Add(new Region("J5", "Miren-Kostanjevica Commune"));
			country.Regions.Add(new Region("J6", "Mirna Pec Commune"));
			country.Regions.Add(new Region("J7", "Novo mesto Urban Commune"));
			country.Regions.Add(new Region("J8", "Oplotnica Commune"));
			country.Regions.Add(new Region("J9", "Piran-Pirano Commune"));
			country.Regions.Add(new Region("K1", "Podlehnik Commune"));
			country.Regions.Add(new Region("K2", "Podvelka Commune"));
			country.Regions.Add(new Region("K3", "Polzela Commune"));
			country.Regions.Add(new Region("K4", "Prebold Commune"));
			country.Regions.Add(new Region("K5", "Preddvor Commune"));
			country.Regions.Add(new Region("K6", "Prevalje Commune"));
			country.Regions.Add(new Region("K7", "Ptuj Urban Commune"));
			country.Regions.Add(new Region("K8", "Ravne na Koroskem Commune"));
			country.Regions.Add(new Region("K9", "Razkrizje Commune"));
			country.Regions.Add(new Region("L1", "Ribnica Commune"));
			country.Regions.Add(new Region("L2", "Ribnica na Pohorju Commune"));
			country.Regions.Add(new Region("L3", "Ruse Commune"));
			country.Regions.Add(new Region("L4", "Salovci Commune"));
			country.Regions.Add(new Region("L5", "Selnica ob Dravi Commune"));
			country.Regions.Add(new Region("L6", "Sempeter-Vrtojba Commune"));
			country.Regions.Add(new Region("L7", "Sentjur pri Celju Commune"));
			country.Regions.Add(new Region("L8", "Slovenska Bistrica Commune"));
			country.Regions.Add(new Region("L9", "Smartno pri Litiji Commune"));
			country.Regions.Add(new Region("M1", "Sodrazica Commune"));
			country.Regions.Add(new Region("M2", "Solcava Commune"));
			country.Regions.Add(new Region("M3", "Sveta Ana Commune"));
			country.Regions.Add(new Region("M4", "Sveti Andraz v Slovenskih goricah Commune"));
			country.Regions.Add(new Region("M5", "Tabor Commune"));
			country.Regions.Add(new Region("M6", "Tisina Commune"));
			country.Regions.Add(new Region("M7", "Trnovska vas Commune"));
			country.Regions.Add(new Region("M8", "Trzin Commune"));
			country.Regions.Add(new Region("M9", "Velika Polana Commune"));
			country.Regions.Add(new Region("N1", "Verzej Commune"));
			country.Regions.Add(new Region("N2", "Videm Commune"));
			country.Regions.Add(new Region("N3", "Vojnik Commune"));
			country.Regions.Add(new Region("N4", "Vransko Commune"));
			country.Regions.Add(new Region("N5", "Zalec Commune"));
			country.Regions.Add(new Region("N6", "Zetale Commune"));
			country.Regions.Add(new Region("N7", "Zirovnica Commune"));
			country.Regions.Add(new Region("N8", "Zuzemberk Commune"));
			country.Regions.Add(new Region("N9", "Apace Commune"));
			country.Regions.Add(new Region("O1", "Cirkulane Commune"));
			countryList.Add(country);

			// Solomon Islands
			country = new Country("Solomon Islands", "SB");
			country.Regions.Add(new Region("03", "Malaita"));
			country.Regions.Add(new Region("06", "Guadalcanal"));
			country.Regions.Add(new Region("07", "Isabel"));
			country.Regions.Add(new Region("08", "Makira"));
			country.Regions.Add(new Region("09", "Temotu"));
			country.Regions.Add(new Region("10", "Central"));
			country.Regions.Add(new Region("11", "Western"));
			country.Regions.Add(new Region("12", "Choiseul"));
			country.Regions.Add(new Region("13", "Rennell and Bellona"));
			countryList.Add(country);

			// Somalia
			country = new Country("Somalia", "SO");
			country.Regions.Add(new Region("01", "Bakool"));
			country.Regions.Add(new Region("02", "Banaadir"));
			country.Regions.Add(new Region("03", "Bari"));
			country.Regions.Add(new Region("04", "Bay"));
			country.Regions.Add(new Region("05", "Galguduud"));
			country.Regions.Add(new Region("06", "Gedo"));
			country.Regions.Add(new Region("07", "Hiiraan"));
			country.Regions.Add(new Region("08", "Jubbada Dhexe"));
			country.Regions.Add(new Region("09", "Jubbada Hoose"));
			country.Regions.Add(new Region("10", "Mudug"));
			country.Regions.Add(new Region("11", "Nugaal"));
			country.Regions.Add(new Region("12", "Sanaag"));
			country.Regions.Add(new Region("13", "Shabeellaha Dhexe"));
			country.Regions.Add(new Region("14", "Shabeellaha Hoose"));
			country.Regions.Add(new Region("16", "Woqooyi Galbeed"));
			country.Regions.Add(new Region("18", "Nugaal"));
			country.Regions.Add(new Region("19", "Togdheer"));
			country.Regions.Add(new Region("20", "Woqooyi Galbeed"));
			country.Regions.Add(new Region("21", "Awdal"));
			country.Regions.Add(new Region("22", "Sool"));
			countryList.Add(country);

			// South Africa
			country = new Country("South Africa", "ZA");
			country.Regions.Add(new Region("01", "North-Western Province"));
			country.Regions.Add(new Region("02", "KwaZulu-Natal"));
			country.Regions.Add(new Region("03", "Free State"));
			country.Regions.Add(new Region("05", "Eastern Cape"));
			country.Regions.Add(new Region("06", "Gauteng"));
			country.Regions.Add(new Region("07", "Mpumalanga"));
			country.Regions.Add(new Region("08", "Northern Cape"));
			country.Regions.Add(new Region("09", "Limpopo"));
			country.Regions.Add(new Region("10", "North-West"));
			country.Regions.Add(new Region("11", "Western Cape"));
			countryList.Add(country);

			// South Sudan
			country = new Country("South Sudan", "SS");
			country.Regions.Add(new Region("01", "Central Equatoria"));
			country.Regions.Add(new Region("02", "Eastern Equatoria"));
			country.Regions.Add(new Region("03", "Jonglei"));
			country.Regions.Add(new Region("04", "Lakes"));
			country.Regions.Add(new Region("05", "Northern Bahr el Ghazal"));
			country.Regions.Add(new Region("06", "Unity"));
			country.Regions.Add(new Region("07", "Upper Nile"));
			country.Regions.Add(new Region("08", "Warrap"));
			country.Regions.Add(new Region("09", "Western Bahr el Ghazal"));
			country.Regions.Add(new Region("10", "Western Equatoria"));
			countryList.Add(country);

			// S. Georgia and S. Sandwich IsIs -------------------------------------------------------------------
			country = new Country("S. Georgia and S. Sandwich IsIs", "GS");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Spain
			country = new Country("Spain", "ES");
			country.Regions.Add(new Region("07", "Islas Baleares"));
			country.Regions.Add(new Region("27", "La Rioja"));
			country.Regions.Add(new Region("29", "Madrid"));
			country.Regions.Add(new Region("31", "Murcia"));
			country.Regions.Add(new Region("32", "Navarra"));
			country.Regions.Add(new Region("34", "Asturias"));
			country.Regions.Add(new Region("39", "Cantabria"));
			country.Regions.Add(new Region("51", "Andalucia"));
			country.Regions.Add(new Region("52", "Aragon"));
			country.Regions.Add(new Region("53", "Canarias"));
			country.Regions.Add(new Region("54", "Castilla-La Mancha"));
			country.Regions.Add(new Region("55", "Castilla y Leon"));
			country.Regions.Add(new Region("56", "Catalonia"));
			country.Regions.Add(new Region("57", "Extremadura"));
			country.Regions.Add(new Region("58", "Galicia"));
			country.Regions.Add(new Region("59", "Pais Vasco"));
			country.Regions.Add(new Region("60", "Comunidad Valenciana"));
			countryList.Add(country);

			// Sri Lanka
			country = new Country("Sri Lanka", "LK");
			country.Regions.Add(new Region("29", "Central"));
			country.Regions.Add(new Region("30", "North Central"));
			country.Regions.Add(new Region("32", "North Western"));
			country.Regions.Add(new Region("33", "Sabaragamuwa"));
			country.Regions.Add(new Region("34", "Southern"));
			country.Regions.Add(new Region("35", "Uva"));
			country.Regions.Add(new Region("36", "Western"));
			country.Regions.Add(new Region("37", "Eastern"));
			country.Regions.Add(new Region("38", "Northern"));
			countryList.Add(country);

			// St. Helena
			country = new Country("St. Helena", "SH");
			country.Regions.Add(new Region("01", "Ascension"));
			country.Regions.Add(new Region("02", "Saint Helena"));
			country.Regions.Add(new Region("03", "Tristan da Cunha"));
			countryList.Add(country);

			// St. Pierre and Miquelon -------------------------------------------------------------------
			country = new Country("St. Pierre and Miquelon", "PM");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Sudan
			country = new Country("Sudan", "SD");
			country.Regions.Add(new Region("27", "Al Wusta"));
			country.Regions.Add(new Region("28", "Al Istiwa'iyah"));
			country.Regions.Add(new Region("29", "Al Khartum"));
			country.Regions.Add(new Region("30", "Ash Shamaliyah"));
			country.Regions.Add(new Region("31", "Ash Sharqiyah"));
			country.Regions.Add(new Region("32", "Bahr al Ghazal"));
			country.Regions.Add(new Region("33", "Darfur"));
			country.Regions.Add(new Region("34", "Kurdufan"));
			country.Regions.Add(new Region("35", "Upper Nile"));
			country.Regions.Add(new Region("40", "Al Wahadah State"));
			country.Regions.Add(new Region("44", "Central Equatoria State"));
			countryList.Add(country);

			// Suriname
			country = new Country("Suriname", "SR");
			country.Regions.Add(new Region("10", "Brokopondo"));
			country.Regions.Add(new Region("11", "Commewijne"));
			country.Regions.Add(new Region("12", "Coronie"));
			country.Regions.Add(new Region("13", "Marowijne"));
			country.Regions.Add(new Region("14", "Nickerie"));
			country.Regions.Add(new Region("15", "Para"));
			country.Regions.Add(new Region("16", "Paramaribo"));
			country.Regions.Add(new Region("17", "Saramacca"));
			country.Regions.Add(new Region("18", "Sipaliwini"));
			country.Regions.Add(new Region("19", "Wanica"));
			countryList.Add(country);

			// Svalbard and Jan Mayen Islands -------------------------------------------------------------------
			country = new Country("Svalbard and Jan Mayen Islands", "SJ");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Swaziland
			country = new Country("Swaziland", "SZ");
			country.Regions.Add(new Region("01", "Hhohho"));
			country.Regions.Add(new Region("02", "Lubombo"));
			country.Regions.Add(new Region("03", "Manzini"));
			country.Regions.Add(new Region("04", "Shiselweni"));
			country.Regions.Add(new Region("05", "Praslin"));
			countryList.Add(country);

			// Sweden
			country = new Country("Sweden", "SE");
			country.Regions.Add(new Region("02", "Blekinge Lan"));
			country.Regions.Add(new Region("03", "Gavleborgs Lan"));
			country.Regions.Add(new Region("05", "Gotlands Lan"));
			country.Regions.Add(new Region("06", "Hallands Lan"));
			country.Regions.Add(new Region("07", "Jamtlands Lan"));
			country.Regions.Add(new Region("08", "Jonkopings Lan"));
			country.Regions.Add(new Region("09", "Kalmar Lan"));
			country.Regions.Add(new Region("10", "Dalarnas Lan"));
			country.Regions.Add(new Region("12", "Kronobergs Lan"));
			country.Regions.Add(new Region("14", "Norrbottens Lan"));
			country.Regions.Add(new Region("15", "Orebro Lan"));
			country.Regions.Add(new Region("16", "Ostergotlands Lan"));
			country.Regions.Add(new Region("18", "Sodermanlands Lan"));
			country.Regions.Add(new Region("21", "Uppsala Lan"));
			country.Regions.Add(new Region("22", "Varmlands Lan"));
			country.Regions.Add(new Region("23", "Vasterbottens Lan"));
			country.Regions.Add(new Region("24", "Vasternorrlands Lan"));
			country.Regions.Add(new Region("25", "Vastmanlands Lan"));
			country.Regions.Add(new Region("26", "Stockholms Lan"));
			country.Regions.Add(new Region("27", "Skane Lan"));
			country.Regions.Add(new Region("28", "Vastra Gotaland"));
			countryList.Add(country);

			// Switzerland
			country = new Country("Switzerland", "CH");
			country.Regions.Add(new Region("01", "Aargau"));
			country.Regions.Add(new Region("02", "Ausser-Rhoden"));
			country.Regions.Add(new Region("03", "Basel-Landschaft"));
			country.Regions.Add(new Region("04", "Basel-Stadt"));
			country.Regions.Add(new Region("05", "Bern"));
			country.Regions.Add(new Region("06", "Fribourg"));
			country.Regions.Add(new Region("07", "Geneve"));
			country.Regions.Add(new Region("08", "Glarus"));
			country.Regions.Add(new Region("09", "Graubunden"));
			country.Regions.Add(new Region("10", "Inner-Rhoden"));
			country.Regions.Add(new Region("11", "Luzern"));
			country.Regions.Add(new Region("12", "Neuchatel"));
			country.Regions.Add(new Region("13", "Nidwalden"));
			country.Regions.Add(new Region("14", "Obwalden"));
			country.Regions.Add(new Region("15", "Sankt Gallen"));
			country.Regions.Add(new Region("16", "Schaffhausen"));
			country.Regions.Add(new Region("17", "Schwyz"));
			country.Regions.Add(new Region("18", "Solothurn"));
			country.Regions.Add(new Region("19", "Thurgau"));
			country.Regions.Add(new Region("20", "Ticino"));
			country.Regions.Add(new Region("21", "Uri"));
			country.Regions.Add(new Region("22", "Valais"));
			country.Regions.Add(new Region("23", "Vaud"));
			country.Regions.Add(new Region("24", "Zug"));
			country.Regions.Add(new Region("25", "Zurich"));
			country.Regions.Add(new Region("26", "Jura"));
			countryList.Add(country);

			// Syria
			country = new Country("Syria", "SY");
			country.Regions.Add(new Region("01", "Al Hasakah"));
			country.Regions.Add(new Region("02", "Al Ladhiqiyah"));
			country.Regions.Add(new Region("03", "Al Qunaytirah"));
			country.Regions.Add(new Region("04", "Ar Raqqah"));
			country.Regions.Add(new Region("05", "As Suwayda'"));
			country.Regions.Add(new Region("06", "Dar"));
			country.Regions.Add(new Region("07", "Dayr az Zawr"));
			country.Regions.Add(new Region("08", "Rif Dimashq"));
			country.Regions.Add(new Region("09", "Halab"));
			country.Regions.Add(new Region("10", "Hamah"));
			country.Regions.Add(new Region("11", "Hims"));
			country.Regions.Add(new Region("12", "Idlib"));
			country.Regions.Add(new Region("13", "Dimashq"));
			country.Regions.Add(new Region("14", "Tartus"));
			countryList.Add(country);

			// Taiwan
			country = new Country("Taiwan", "TW");
			country.Regions.Add(new Region("01", "Fu-chien"));
			country.Regions.Add(new Region("02", "Kao-hsiung"));
			country.Regions.Add(new Region("03", "T'ai-pei"));
			country.Regions.Add(new Region("04", "T'ai-wan"));
			countryList.Add(country);

			// Tajikistan
			country = new Country("Tajikistan", "TJ");
			country.Regions.Add(new Region("01", "Kuhistoni Badakhshon"));
			country.Regions.Add(new Region("02", "Khatlon"));
			country.Regions.Add(new Region("03", "Sughd"));
			countryList.Add(country);

			// Tanzania
			country = new Country("Tanzania", "TZ");
			country.Regions.Add(new Region("02", "Pwani"));
			country.Regions.Add(new Region("03", "Dodoma"));
			country.Regions.Add(new Region("04", "Iringa"));
			country.Regions.Add(new Region("05", "Kigoma"));
			country.Regions.Add(new Region("06", "Kilimanjaro"));
			country.Regions.Add(new Region("07", "Lindi"));
			country.Regions.Add(new Region("08", "Mara"));
			country.Regions.Add(new Region("09", "Mbeya"));
			country.Regions.Add(new Region("10", "Morogoro"));
			country.Regions.Add(new Region("11", "Mtwara"));
			country.Regions.Add(new Region("12", "Mwanza"));
			country.Regions.Add(new Region("13", "Pemba North"));
			country.Regions.Add(new Region("14", "Ruvuma"));
			country.Regions.Add(new Region("15", "Shinyanga"));
			country.Regions.Add(new Region("16", "Singida"));
			country.Regions.Add(new Region("17", "Tabora"));
			country.Regions.Add(new Region("18", "Tanga"));
			country.Regions.Add(new Region("19", "Kagera"));
			country.Regions.Add(new Region("20", "Pemba South"));
			country.Regions.Add(new Region("21", "Zanzibar Central"));
			country.Regions.Add(new Region("22", "Zanzibar North"));
			country.Regions.Add(new Region("23", "Dar es Salaam"));
			country.Regions.Add(new Region("24", "Rukwa"));
			country.Regions.Add(new Region("25", "Zanzibar Urban"));
			country.Regions.Add(new Region("26", "Arusha"));
			country.Regions.Add(new Region("27", "Manyara"));
			countryList.Add(country);

			// Thailand
			country = new Country("Thailand", "TH");
			country.Regions.Add(new Region("01", "Mae Hong Son"));
			country.Regions.Add(new Region("02", "Chiang Mai"));
			country.Regions.Add(new Region("03", "Chiang Rai"));
			country.Regions.Add(new Region("04", "Nan"));
			country.Regions.Add(new Region("05", "Lamphun"));
			country.Regions.Add(new Region("06", "Lampang"));
			country.Regions.Add(new Region("07", "Phrae"));
			country.Regions.Add(new Region("08", "Tak"));
			country.Regions.Add(new Region("09", "Sukhothai"));
			country.Regions.Add(new Region("10", "Uttaradit"));
			country.Regions.Add(new Region("11", "Kamphaeng Phet"));
			country.Regions.Add(new Region("12", "Phitsanulok"));
			country.Regions.Add(new Region("13", "Phichit"));
			country.Regions.Add(new Region("14", "Phetchabun"));
			country.Regions.Add(new Region("15", "Uthai Thani"));
			country.Regions.Add(new Region("16", "Nakhon Sawan"));
			country.Regions.Add(new Region("17", "Nong Khai"));
			country.Regions.Add(new Region("18", "Loei"));
			country.Regions.Add(new Region("20", "Sakon Nakhon"));
			country.Regions.Add(new Region("21", "Nakhon Phanom"));
			country.Regions.Add(new Region("22", "Khon Kaen"));
			country.Regions.Add(new Region("23", "Kalasin"));
			country.Regions.Add(new Region("24", "Maha Sarakham"));
			country.Regions.Add(new Region("25", "Roi Et"));
			country.Regions.Add(new Region("26", "Chaiyaphum"));
			country.Regions.Add(new Region("27", "Nakhon Ratchasima"));
			country.Regions.Add(new Region("28", "Buriram"));
			country.Regions.Add(new Region("29", "Surin"));
			country.Regions.Add(new Region("30", "Sisaket"));
			country.Regions.Add(new Region("31", "Narathiwat"));
			country.Regions.Add(new Region("32", "Chai Nat"));
			country.Regions.Add(new Region("33", "Sing Buri"));
			country.Regions.Add(new Region("34", "Lop Buri"));
			country.Regions.Add(new Region("35", "Ang Thong"));
			country.Regions.Add(new Region("36", "Phra Nakhon Si Ayutthaya"));
			country.Regions.Add(new Region("37", "Saraburi"));
			country.Regions.Add(new Region("38", "Nonthaburi"));
			country.Regions.Add(new Region("39", "Pathum Thani"));
			country.Regions.Add(new Region("40", "Krung Thep"));
			country.Regions.Add(new Region("41", "Phayao"));
			country.Regions.Add(new Region("42", "Samut Prakan"));
			country.Regions.Add(new Region("43", "Nakhon Nayok"));
			country.Regions.Add(new Region("44", "Chachoengsao"));
			country.Regions.Add(new Region("45", "Prachin Buri"));
			country.Regions.Add(new Region("46", "Chon Buri"));
			country.Regions.Add(new Region("47", "Rayong"));
			country.Regions.Add(new Region("48", "Chanthaburi"));
			country.Regions.Add(new Region("49", "Trat"));
			country.Regions.Add(new Region("50", "Kanchanaburi"));
			country.Regions.Add(new Region("51", "Suphan Buri"));
			country.Regions.Add(new Region("52", "Ratchaburi"));
			country.Regions.Add(new Region("53", "Nakhon Pathom"));
			country.Regions.Add(new Region("54", "Samut Songkhram"));
			country.Regions.Add(new Region("55", "Samut Sakhon"));
			country.Regions.Add(new Region("56", "Phetchaburi"));
			country.Regions.Add(new Region("57", "Prachuap Khiri Khan"));
			country.Regions.Add(new Region("58", "Chumphon"));
			country.Regions.Add(new Region("59", "Ranong"));
			country.Regions.Add(new Region("60", "Surat Thani"));
			country.Regions.Add(new Region("61", "Phangnga"));
			country.Regions.Add(new Region("62", "Phuket"));
			country.Regions.Add(new Region("63", "Krabi"));
			country.Regions.Add(new Region("64", "Nakhon Si Thammarat"));
			country.Regions.Add(new Region("65", "Trang"));
			country.Regions.Add(new Region("66", "Phatthalung"));
			country.Regions.Add(new Region("67", "Satun"));
			country.Regions.Add(new Region("68", "Songkhla"));
			country.Regions.Add(new Region("69", "Pattani"));
			country.Regions.Add(new Region("70", "Yala"));
			country.Regions.Add(new Region("71", "Ubon Ratchathani"));
			country.Regions.Add(new Region("72", "Yasothon"));
			country.Regions.Add(new Region("73", "Nakhon Phanom"));
			country.Regions.Add(new Region("74", "Prachin Buri"));
			country.Regions.Add(new Region("75", "Ubon Ratchathani"));
			country.Regions.Add(new Region("76", "Udon Thani"));
			country.Regions.Add(new Region("77", "Amnat Charoen"));
			country.Regions.Add(new Region("78", "Mukdahan"));
			country.Regions.Add(new Region("79", "Nong Bua Lamphu"));
			country.Regions.Add(new Region("80", "Sa Kaeo"));
			countryList.Add(country);

			// Togo
			country = new Country("Togo", "TG");
			country.Regions.Add(new Region("22", "Centrale"));
			country.Regions.Add(new Region("23", "Kara"));
			country.Regions.Add(new Region("24", "Maritime"));
			country.Regions.Add(new Region("25", "Plateaux"));
			country.Regions.Add(new Region("26", "Savanes"));
			countryList.Add(country);

			// Tokelau -------------------------------------------------------------------
			//country = new Country("Tokelau", "TK");
			//countryList.Add(country);

			// Tonga
			country = new Country("Tonga", "TO");
			country.Regions.Add(new Region("01", "Ha"));
			country.Regions.Add(new Region("02", "Tongatapu"));
			country.Regions.Add(new Region("03", "Vava"));
			countryList.Add(country);

			// Trinidad and Tobago
			country = new Country("Trinidad and Tobago", "TT");
			country.Regions.Add(new Region("01", "Arima"));
			country.Regions.Add(new Region("02", "Caroni"));
			country.Regions.Add(new Region("03", "Mayaro"));
			country.Regions.Add(new Region("04", "Nariva"));
			country.Regions.Add(new Region("05", "Port-of-Spain"));
			country.Regions.Add(new Region("06", "Saint Andrew"));
			country.Regions.Add(new Region("07", "Saint David"));
			country.Regions.Add(new Region("08", "Saint George"));
			country.Regions.Add(new Region("09", "Saint Patrick"));
			country.Regions.Add(new Region("10", "San Fernando"));
			country.Regions.Add(new Region("11", "Tobago"));
			country.Regions.Add(new Region("12", "Victoria"));
			countryList.Add(country);

			// Tunisia
			country = new Country("Tunisia", "TN");
			country.Regions.Add(new Region("02", "Kasserine"));
			country.Regions.Add(new Region("03", "Kairouan"));
			country.Regions.Add(new Region("06", "Jendouba"));
			country.Regions.Add(new Region("10", "Qafsah"));
			country.Regions.Add(new Region("14", "El Kef"));
			country.Regions.Add(new Region("15", "Al Mahdia"));
			country.Regions.Add(new Region("16", "Al Munastir"));
			country.Regions.Add(new Region("17", "Bajah"));
			country.Regions.Add(new Region("18", "Bizerte"));
			country.Regions.Add(new Region("19", "Nabeul"));
			country.Regions.Add(new Region("22", "Siliana"));
			country.Regions.Add(new Region("23", "Sousse"));
			country.Regions.Add(new Region("27", "Ben Arous"));
			country.Regions.Add(new Region("28", "Madanin"));
			country.Regions.Add(new Region("29", "Gabes"));
			country.Regions.Add(new Region("31", "Kebili"));
			country.Regions.Add(new Region("32", "Sfax"));
			country.Regions.Add(new Region("33", "Sidi Bou Zid"));
			country.Regions.Add(new Region("34", "Tataouine"));
			country.Regions.Add(new Region("35", "Tozeur"));
			country.Regions.Add(new Region("36", "Tunis"));
			country.Regions.Add(new Region("37", "Zaghouan"));
			country.Regions.Add(new Region("38", "Aiana"));
			country.Regions.Add(new Region("39", "Manouba"));
			countryList.Add(country);

			// Turkey
			country = new Country("Turkey", "TR");
			country.Regions.Add(new Region("02", "Adiyaman"));
			country.Regions.Add(new Region("03", "Afyonkarahisar"));
			country.Regions.Add(new Region("04", "Agri"));
			country.Regions.Add(new Region("05", "Amasya"));
			country.Regions.Add(new Region("07", "Antalya"));
			country.Regions.Add(new Region("08", "Artvin"));
			country.Regions.Add(new Region("09", "Aydin"));
			country.Regions.Add(new Region("10", "Balikesir"));
			country.Regions.Add(new Region("11", "Bilecik"));
			country.Regions.Add(new Region("12", "Bingol"));
			country.Regions.Add(new Region("13", "Bitlis"));
			country.Regions.Add(new Region("14", "Bolu"));
			country.Regions.Add(new Region("15", "Burdur"));
			country.Regions.Add(new Region("16", "Bursa"));
			country.Regions.Add(new Region("17", "Canakkale"));
			country.Regions.Add(new Region("19", "Corum"));
			country.Regions.Add(new Region("20", "Denizli"));
			country.Regions.Add(new Region("21", "Diyarbakir"));
			country.Regions.Add(new Region("22", "Edirne"));
			country.Regions.Add(new Region("23", "Elazig"));
			country.Regions.Add(new Region("24", "Erzincan"));
			country.Regions.Add(new Region("25", "Erzurum"));
			country.Regions.Add(new Region("26", "Eskisehir"));
			country.Regions.Add(new Region("28", "Giresun"));
			country.Regions.Add(new Region("31", "Hatay"));
			country.Regions.Add(new Region("32", "Mersin"));
			country.Regions.Add(new Region("33", "Isparta"));
			country.Regions.Add(new Region("34", "Istanbul"));
			country.Regions.Add(new Region("35", "Izmir"));
			country.Regions.Add(new Region("37", "Kastamonu"));
			country.Regions.Add(new Region("38", "Kayseri"));
			country.Regions.Add(new Region("39", "Kirklareli"));
			country.Regions.Add(new Region("40", "Kirsehir"));
			country.Regions.Add(new Region("41", "Kocaeli"));
			country.Regions.Add(new Region("43", "Kutahya"));
			country.Regions.Add(new Region("44", "Malatya"));
			country.Regions.Add(new Region("45", "Manisa"));
			country.Regions.Add(new Region("46", "Kahramanmaras"));
			country.Regions.Add(new Region("48", "Mugla"));
			country.Regions.Add(new Region("49", "Mus"));
			country.Regions.Add(new Region("50", "Nevsehir"));
			country.Regions.Add(new Region("52", "Ordu"));
			country.Regions.Add(new Region("53", "Rize"));
			country.Regions.Add(new Region("54", "Sakarya"));
			country.Regions.Add(new Region("55", "Samsun"));
			country.Regions.Add(new Region("57", "Sinop"));
			country.Regions.Add(new Region("58", "Sivas"));
			country.Regions.Add(new Region("59", "Tekirdag"));
			country.Regions.Add(new Region("60", "Tokat"));
			country.Regions.Add(new Region("61", "Trabzon"));
			country.Regions.Add(new Region("62", "Tunceli"));
			country.Regions.Add(new Region("63", "Sanliurfa"));
			country.Regions.Add(new Region("64", "Usak"));
			country.Regions.Add(new Region("65", "Van"));
			country.Regions.Add(new Region("66", "Yozgat"));
			country.Regions.Add(new Region("68", "Ankara"));
			country.Regions.Add(new Region("69", "Gumushane"));
			country.Regions.Add(new Region("70", "Hakkari"));
			country.Regions.Add(new Region("71", "Konya"));
			country.Regions.Add(new Region("72", "Mardin"));
			country.Regions.Add(new Region("73", "Nigde"));
			country.Regions.Add(new Region("74", "Siirt"));
			country.Regions.Add(new Region("75", "Aksaray"));
			country.Regions.Add(new Region("76", "Batman"));
			country.Regions.Add(new Region("77", "Bayburt"));
			country.Regions.Add(new Region("78", "Karaman"));
			country.Regions.Add(new Region("79", "Kirikkale"));
			country.Regions.Add(new Region("80", "Sirnak"));
			country.Regions.Add(new Region("81", "Adana"));
			country.Regions.Add(new Region("82", "Cankiri"));
			country.Regions.Add(new Region("83", "Gaziantep"));
			country.Regions.Add(new Region("84", "Kars"));
			country.Regions.Add(new Region("85", "Zonguldak"));
			country.Regions.Add(new Region("86", "Ardahan"));
			country.Regions.Add(new Region("87", "Bartin"));
			country.Regions.Add(new Region("88", "Igdir"));
			country.Regions.Add(new Region("89", "Karabuk"));
			country.Regions.Add(new Region("90", "Kilis"));
			country.Regions.Add(new Region("91", "Osmaniye"));
			country.Regions.Add(new Region("92", "Yalova"));
			country.Regions.Add(new Region("93", "Duzce"));
			countryList.Add(country);

			// Turkmenistan
			country = new Country("Turkmenistan", "TM");
			country.Regions.Add(new Region("01", "Ahal"));
			country.Regions.Add(new Region("02", "Balkan"));
			country.Regions.Add(new Region("03", "Dashoguz"));
			country.Regions.Add(new Region("04", "Lebap"));
			country.Regions.Add(new Region("05", "Mary"));
			countryList.Add(country);

			// Turks and Caicos Islands -------------------------------------------------------------------
			country = new Country("Turks and Caicos Islands", "TC");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Tuvalu -------------------------------------------------------------------
			country = new Country("Tuvalu", "TV");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Uganda
			country = new Country("Uganda", "UG");
			country.Regions.Add(new Region("26", "Apac"));
			country.Regions.Add(new Region("28", "Bundibugyo"));
			country.Regions.Add(new Region("29", "Bushenyi"));
			country.Regions.Add(new Region("30", "Gulu"));
			country.Regions.Add(new Region("31", "Hoima"));
			country.Regions.Add(new Region("33", "Jinja"));
			country.Regions.Add(new Region("36", "Kalangala"));
			country.Regions.Add(new Region("37", "Kampala"));
			country.Regions.Add(new Region("38", "Kamuli"));
			country.Regions.Add(new Region("39", "Kapchorwa"));
			country.Regions.Add(new Region("40", "Kasese"));
			country.Regions.Add(new Region("41", "Kibale"));
			country.Regions.Add(new Region("42", "Kiboga"));
			country.Regions.Add(new Region("43", "Kisoro"));
			country.Regions.Add(new Region("45", "Kotido"));
			country.Regions.Add(new Region("46", "Kumi"));
			country.Regions.Add(new Region("47", "Lira"));
			country.Regions.Add(new Region("50", "Masindi"));
			country.Regions.Add(new Region("52", "Mbarara"));
			country.Regions.Add(new Region("56", "Mubende"));
			country.Regions.Add(new Region("58", "Nebbi"));
			country.Regions.Add(new Region("59", "Ntungamo"));
			country.Regions.Add(new Region("60", "Pallisa"));
			country.Regions.Add(new Region("61", "Rakai"));
			country.Regions.Add(new Region("65", "Adjumani"));
			country.Regions.Add(new Region("66", "Bugiri"));
			country.Regions.Add(new Region("67", "Busia"));
			country.Regions.Add(new Region("69", "Katakwi"));
			country.Regions.Add(new Region("70", "Luwero"));
			country.Regions.Add(new Region("71", "Masaka"));
			country.Regions.Add(new Region("72", "Moyo"));
			country.Regions.Add(new Region("73", "Nakasongola"));
			country.Regions.Add(new Region("74", "Sembabule"));
			country.Regions.Add(new Region("76", "Tororo"));
			country.Regions.Add(new Region("77", "Arua"));
			country.Regions.Add(new Region("78", "Iganga"));
			country.Regions.Add(new Region("79", "Kabarole"));
			country.Regions.Add(new Region("80", "Kaberamaido"));
			country.Regions.Add(new Region("81", "Kamwenge"));
			country.Regions.Add(new Region("82", "Kanungu"));
			country.Regions.Add(new Region("83", "Kayunga"));
			country.Regions.Add(new Region("84", "Kitgum"));
			country.Regions.Add(new Region("85", "Kyenjojo"));
			country.Regions.Add(new Region("86", "Mayuge"));
			country.Regions.Add(new Region("87", "Mbale"));
			country.Regions.Add(new Region("88", "Moroto"));
			country.Regions.Add(new Region("89", "Mpigi"));
			country.Regions.Add(new Region("90", "Mukono"));
			country.Regions.Add(new Region("91", "Nakapiripirit"));
			country.Regions.Add(new Region("92", "Pader"));
			country.Regions.Add(new Region("93", "Rukungiri"));
			country.Regions.Add(new Region("94", "Sironko"));
			country.Regions.Add(new Region("95", "Soroti"));
			country.Regions.Add(new Region("96", "Wakiso"));
			country.Regions.Add(new Region("97", "Yumbe"));
			countryList.Add(country);

			// Ukraine
			country = new Country("Ukraine", "UA");
			country.Regions.Add(new Region("01", "Cherkas'ka Oblast'"));
			country.Regions.Add(new Region("02", "Chernihivs'ka Oblast'"));
			country.Regions.Add(new Region("03", "Chernivets'ka Oblast'"));
			country.Regions.Add(new Region("04", "Dnipropetrovs'ka Oblast'"));
			country.Regions.Add(new Region("05", "Donets'ka Oblast'"));
			country.Regions.Add(new Region("06", "Ivano-Frankivs'ka Oblast'"));
			country.Regions.Add(new Region("07", "Kharkivs'ka Oblast'"));
			country.Regions.Add(new Region("08", "Khersons'ka Oblast'"));
			country.Regions.Add(new Region("09", "Khmel'nyts'ka Oblast'"));
			country.Regions.Add(new Region("10", "Kirovohrads'ka Oblast'"));
			country.Regions.Add(new Region("11", "Krym"));
			country.Regions.Add(new Region("12", "Kyyiv"));
			country.Regions.Add(new Region("13", "Kyyivs'ka Oblast'"));
			country.Regions.Add(new Region("14", "Luhans'ka Oblast'"));
			country.Regions.Add(new Region("15", "L'vivs'ka Oblast'"));
			country.Regions.Add(new Region("16", "Mykolayivs'ka Oblast'"));
			country.Regions.Add(new Region("17", "Odes'ka Oblast'"));
			country.Regions.Add(new Region("18", "Poltavs'ka Oblast'"));
			country.Regions.Add(new Region("19", "Rivnens'ka Oblast'"));
			country.Regions.Add(new Region("20", "Sevastopol'"));
			country.Regions.Add(new Region("21", "Sums'ka Oblast'"));
			country.Regions.Add(new Region("22", "Ternopil's'ka Oblast'"));
			country.Regions.Add(new Region("23", "Vinnyts'ka Oblast'"));
			country.Regions.Add(new Region("24", "Volyns'ka Oblast'"));
			country.Regions.Add(new Region("25", "Zakarpats'ka Oblast'"));
			country.Regions.Add(new Region("26", "Zaporiz'ka Oblast'"));
			country.Regions.Add(new Region("27", "Zhytomyrs'ka Oblast'"));
			countryList.Add(country);

			// United Arab Emirates
			country = new Country("United Arab Emirates", "AE");
			country.Regions.Add(new Region("01", "Abu Dhabi"));
			country.Regions.Add(new Region("02", "Ajman"));
			country.Regions.Add(new Region("03", "Dubai"));
			country.Regions.Add(new Region("04", "Fujairah"));
			country.Regions.Add(new Region("05", "Ras Al Khaimah"));
			country.Regions.Add(new Region("06", "Sharjah"));
			country.Regions.Add(new Region("07", "Umm Al Quwain"));
			countryList.Add(country);

			// United Kingdom
			country = new Country("United Kingdom", "GB");
			country.Regions.Add(new Region("A1", "Barking and Dagenham"));
			country.Regions.Add(new Region("A2", "Barnet"));
			country.Regions.Add(new Region("A3", "Barnsley"));
			country.Regions.Add(new Region("A4", "Bath and North East Somerset"));
			country.Regions.Add(new Region("A5", "Bedfordshire"));
			country.Regions.Add(new Region("A6", "Bexley"));
			country.Regions.Add(new Region("A7", "Birmingham"));
			country.Regions.Add(new Region("A8", "Blackburn with Darwen"));
			country.Regions.Add(new Region("A9", "Blackpool"));
			country.Regions.Add(new Region("B1", "Bolton"));
			country.Regions.Add(new Region("B2", "Bournemouth"));
			country.Regions.Add(new Region("B3", "Bracknell Forest"));
			country.Regions.Add(new Region("B4", "Bradford"));
			country.Regions.Add(new Region("B5", "Brent"));
			country.Regions.Add(new Region("B6", "Brighton and Hove"));
			country.Regions.Add(new Region("B7", "Bristol"));
			country.Regions.Add(new Region("B8", "Bromley"));
			country.Regions.Add(new Region("B9", "Buckinghamshire"));
			country.Regions.Add(new Region("C1", "Bury"));
			country.Regions.Add(new Region("C2", "Calderdale"));
			country.Regions.Add(new Region("C3", "Cambridgeshire"));
			country.Regions.Add(new Region("C4", "Camden"));
			country.Regions.Add(new Region("C5", "Cheshire"));
			country.Regions.Add(new Region("C6", "Cornwall"));
			country.Regions.Add(new Region("C7", "Coventry"));
			country.Regions.Add(new Region("C8", "Croydon"));
			country.Regions.Add(new Region("C9", "Cumbria"));
			country.Regions.Add(new Region("D1", "Darlington"));
			country.Regions.Add(new Region("D2", "Derby"));
			country.Regions.Add(new Region("D3", "Derbyshire"));
			country.Regions.Add(new Region("D4", "Devon"));
			country.Regions.Add(new Region("D5", "Doncaster"));
			country.Regions.Add(new Region("D6", "Dorset"));
			country.Regions.Add(new Region("D7", "Dudley"));
			country.Regions.Add(new Region("D8", "Durham"));
			country.Regions.Add(new Region("D9", "Ealing"));
			country.Regions.Add(new Region("E1", "East Riding of Yorkshire"));
			country.Regions.Add(new Region("E2", "East Sussex"));
			country.Regions.Add(new Region("E3", "Enfield"));
			country.Regions.Add(new Region("E4", "Essex"));
			country.Regions.Add(new Region("E5", "Gateshead"));
			country.Regions.Add(new Region("E6", "Gloucestershire"));
			country.Regions.Add(new Region("E7", "Greenwich"));
			country.Regions.Add(new Region("E8", "Hackney"));
			country.Regions.Add(new Region("E9", "Halton"));
			country.Regions.Add(new Region("F1", "Hammersmith and Fulham"));
			country.Regions.Add(new Region("F2", "Hampshire"));
			country.Regions.Add(new Region("F3", "Haringey"));
			country.Regions.Add(new Region("F4", "Harrow"));
			country.Regions.Add(new Region("F5", "Hartlepool"));
			country.Regions.Add(new Region("F6", "Havering"));
			country.Regions.Add(new Region("F7", "Herefordshire"));
			country.Regions.Add(new Region("F8", "Hertford"));
			country.Regions.Add(new Region("F9", "Hillingdon"));
			country.Regions.Add(new Region("G1", "Hounslow"));
			country.Regions.Add(new Region("G2", "Isle of Wight"));
			country.Regions.Add(new Region("G3", "Islington"));
			country.Regions.Add(new Region("G4", "Kensington and Chelsea"));
			country.Regions.Add(new Region("G5", "Kent"));
			country.Regions.Add(new Region("G6", "Kingston upon Hull"));
			country.Regions.Add(new Region("G7", "Kingston upon Thames"));
			country.Regions.Add(new Region("G8", "Kirklees"));
			country.Regions.Add(new Region("G9", "Knowsley"));
			country.Regions.Add(new Region("H1", "Lambeth"));
			country.Regions.Add(new Region("H2", "Lancashire"));
			country.Regions.Add(new Region("H3", "Leeds"));
			country.Regions.Add(new Region("H4", "Leicester"));
			country.Regions.Add(new Region("H5", "Leicestershire"));
			country.Regions.Add(new Region("H6", "Lewisham"));
			country.Regions.Add(new Region("H7", "Lincolnshire"));
			country.Regions.Add(new Region("H8", "Liverpool"));
			country.Regions.Add(new Region("H9", "London"));
			country.Regions.Add(new Region("I1", "Luton"));
			country.Regions.Add(new Region("I2", "Manchester"));
			country.Regions.Add(new Region("I3", "Medway"));
			country.Regions.Add(new Region("I4", "Merton"));
			country.Regions.Add(new Region("I5", "Middlesbrough"));
			country.Regions.Add(new Region("I6", "Milton Keynes"));
			country.Regions.Add(new Region("I7", "Newcastle upon Tyne"));
			country.Regions.Add(new Region("I8", "Newham"));
			country.Regions.Add(new Region("I9", "Norfolk"));
			country.Regions.Add(new Region("J1", "Northamptonshire"));
			country.Regions.Add(new Region("J2", "North East Lincolnshire"));
			country.Regions.Add(new Region("J3", "North Lincolnshire"));
			country.Regions.Add(new Region("J4", "North Somerset"));
			country.Regions.Add(new Region("J5", "North Tyneside"));
			country.Regions.Add(new Region("J6", "Northumberland"));
			country.Regions.Add(new Region("J7", "North Yorkshire"));
			country.Regions.Add(new Region("J8", "Nottingham"));
			country.Regions.Add(new Region("J9", "Nottinghamshire"));
			country.Regions.Add(new Region("K1", "Oldham"));
			country.Regions.Add(new Region("K2", "Oxfordshire"));
			country.Regions.Add(new Region("K3", "Peterborough"));
			country.Regions.Add(new Region("K4", "Plymouth"));
			country.Regions.Add(new Region("K5", "Poole"));
			country.Regions.Add(new Region("K6", "Portsmouth"));
			country.Regions.Add(new Region("K7", "Reading"));
			country.Regions.Add(new Region("K8", "Redbridge"));
			country.Regions.Add(new Region("K9", "Redcar and Cleveland"));
			country.Regions.Add(new Region("L1", "Richmond upon Thames"));
			country.Regions.Add(new Region("L2", "Rochdale"));
			country.Regions.Add(new Region("L3", "Rotherham"));
			country.Regions.Add(new Region("L4", "Rutland"));
			country.Regions.Add(new Region("L5", "Salford"));
			country.Regions.Add(new Region("L6", "Shropshire"));
			country.Regions.Add(new Region("L7", "Sandwell"));
			country.Regions.Add(new Region("L8", "Sefton"));
			country.Regions.Add(new Region("L9", "Sheffield"));
			country.Regions.Add(new Region("M1", "Slough"));
			country.Regions.Add(new Region("M2", "Solihull"));
			country.Regions.Add(new Region("M3", "Somerset"));
			country.Regions.Add(new Region("M4", "Southampton"));
			country.Regions.Add(new Region("M5", "Southend-on-Sea"));
			country.Regions.Add(new Region("M6", "South Gloucestershire"));
			country.Regions.Add(new Region("M7", "South Tyneside"));
			country.Regions.Add(new Region("M8", "Southwark"));
			country.Regions.Add(new Region("M9", "Staffordshire"));
			country.Regions.Add(new Region("N1", "St. Helens"));
			country.Regions.Add(new Region("N2", "Stockport"));
			country.Regions.Add(new Region("N3", "Stockton-on-Tees"));
			country.Regions.Add(new Region("N4", "Stoke-on-Trent"));
			country.Regions.Add(new Region("N5", "Suffolk"));
			country.Regions.Add(new Region("N6", "Sunderland"));
			country.Regions.Add(new Region("N7", "Surrey"));
			country.Regions.Add(new Region("N8", "Sutton"));
			country.Regions.Add(new Region("N9", "Swindon"));
			country.Regions.Add(new Region("O1", "Tameside"));
			country.Regions.Add(new Region("O2", "Telford and Wrekin"));
			country.Regions.Add(new Region("O3", "Thurrock"));
			country.Regions.Add(new Region("O4", "Torbay"));
			country.Regions.Add(new Region("O5", "Tower Hamlets"));
			country.Regions.Add(new Region("O6", "Trafford"));
			country.Regions.Add(new Region("O7", "Wakefield"));
			country.Regions.Add(new Region("O8", "Walsall"));
			country.Regions.Add(new Region("O9", "Waltham Forest"));
			country.Regions.Add(new Region("P1", "Wandsworth"));
			country.Regions.Add(new Region("P2", "Warrington"));
			country.Regions.Add(new Region("P3", "Warwickshire"));
			country.Regions.Add(new Region("P4", "West Berkshire"));
			country.Regions.Add(new Region("P5", "Westminster"));
			country.Regions.Add(new Region("P6", "West Sussex"));
			country.Regions.Add(new Region("P7", "Wigan"));
			country.Regions.Add(new Region("P8", "Wiltshire"));
			country.Regions.Add(new Region("P9", "Windsor and Maidenhead"));
			country.Regions.Add(new Region("Q1", "Wirral"));
			country.Regions.Add(new Region("Q2", "Wokingham"));
			country.Regions.Add(new Region("Q3", "Wolverhampton"));
			country.Regions.Add(new Region("Q4", "Worcestershire"));
			country.Regions.Add(new Region("Q5", "York"));
			country.Regions.Add(new Region("Q6", "Antrim"));
			country.Regions.Add(new Region("Q7", "Ards"));
			country.Regions.Add(new Region("Q8", "Armagh"));
			country.Regions.Add(new Region("Q9", "Ballymena"));
			country.Regions.Add(new Region("R1", "Ballymoney"));
			country.Regions.Add(new Region("R2", "Banbridge"));
			country.Regions.Add(new Region("R3", "Belfast"));
			country.Regions.Add(new Region("R4", "Carrickfergus"));
			country.Regions.Add(new Region("R5", "Castlereagh"));
			country.Regions.Add(new Region("R6", "Coleraine"));
			country.Regions.Add(new Region("R7", "Cookstown"));
			country.Regions.Add(new Region("R8", "Craigavon"));
			country.Regions.Add(new Region("R9", "Down"));
			country.Regions.Add(new Region("S1", "Dungannon"));
			country.Regions.Add(new Region("S2", "Fermanagh"));
			country.Regions.Add(new Region("S3", "Larne"));
			country.Regions.Add(new Region("S4", "Limavady"));
			country.Regions.Add(new Region("S5", "Lisburn"));
			country.Regions.Add(new Region("S6", "Derry"));
			country.Regions.Add(new Region("S7", "Magherafelt"));
			country.Regions.Add(new Region("S8", "Moyle"));
			country.Regions.Add(new Region("S9", "Newry and Mourne"));
			country.Regions.Add(new Region("T1", "Newtownabbey"));
			country.Regions.Add(new Region("T2", "North Down"));
			country.Regions.Add(new Region("T3", "Omagh"));
			country.Regions.Add(new Region("T4", "Strabane"));
			country.Regions.Add(new Region("T5", "Aberdeen City"));
			country.Regions.Add(new Region("T6", "Aberdeenshire"));
			country.Regions.Add(new Region("T7", "Angus"));
			country.Regions.Add(new Region("T8", "Argyll and Bute"));
			country.Regions.Add(new Region("T9", "Scottish Borders)); The"));
			country.Regions.Add(new Region("U1", "Clackmannanshire"));
			country.Regions.Add(new Region("U2", "Dumfries and Galloway"));
			country.Regions.Add(new Region("U3", "Dundee City"));
			country.Regions.Add(new Region("U4", "East Ayrshire"));
			country.Regions.Add(new Region("U5", "East Dunbartonshire"));
			country.Regions.Add(new Region("U6", "East Lothian"));
			country.Regions.Add(new Region("U7", "East Renfrewshire"));
			country.Regions.Add(new Region("U8", "Edinburgh"));
			country.Regions.Add(new Region("U9", "Falkirk"));
			country.Regions.Add(new Region("V1", "Fife"));
			country.Regions.Add(new Region("V2", "Glasgow City"));
			country.Regions.Add(new Region("V3", "Highland"));
			country.Regions.Add(new Region("V4", "Inverclyde"));
			country.Regions.Add(new Region("V5", "Midlothian"));
			country.Regions.Add(new Region("V6", "Moray"));
			country.Regions.Add(new Region("V7", "North Ayrshire"));
			country.Regions.Add(new Region("V8", "North Lanarkshire"));
			country.Regions.Add(new Region("V9", "Orkney"));
			country.Regions.Add(new Region("W1", "Perth and Kinross"));
			country.Regions.Add(new Region("W2", "Renfrewshire"));
			country.Regions.Add(new Region("W3", "Shetland Islands"));
			country.Regions.Add(new Region("W4", "South Ayrshire"));
			country.Regions.Add(new Region("W5", "South Lanarkshire"));
			country.Regions.Add(new Region("W6", "Stirling"));
			country.Regions.Add(new Region("W7", "West Dunbartonshire"));
			country.Regions.Add(new Region("W8", "Eilean Siar"));
			country.Regions.Add(new Region("W9", "West Lothian"));
			country.Regions.Add(new Region("X1", "Isle of Anglesey"));
			country.Regions.Add(new Region("X2", "Blaenau Gwent"));
			country.Regions.Add(new Region("X3", "Bridgend"));
			country.Regions.Add(new Region("X4", "Caerphilly"));
			country.Regions.Add(new Region("X5", "Cardiff"));
			country.Regions.Add(new Region("X6", "Ceredigion"));
			country.Regions.Add(new Region("X7", "Carmarthenshire"));
			country.Regions.Add(new Region("X8", "Conwy"));
			country.Regions.Add(new Region("X9", "Denbighshire"));
			country.Regions.Add(new Region("Y1", "Flintshire"));
			country.Regions.Add(new Region("Y2", "Gwynedd"));
			country.Regions.Add(new Region("Y3", "Merthyr Tydfil"));
			country.Regions.Add(new Region("Y4", "Monmouthshire"));
			country.Regions.Add(new Region("Y5", "Neath Port Talbot"));
			country.Regions.Add(new Region("Y6", "Newport"));
			country.Regions.Add(new Region("Y7", "Pembrokeshire"));
			country.Regions.Add(new Region("Y8", "Powys"));
			country.Regions.Add(new Region("Y9", "Rhondda Cynon Taff"));
			country.Regions.Add(new Region("Z1", "Swansea"));
			country.Regions.Add(new Region("Z2", "Torfaen"));
			country.Regions.Add(new Region("Z3", "Vale of Glamorgan)); The"));
			country.Regions.Add(new Region("Z4", "Wrexham"));
			country.Regions.Add(new Region("Z5", "Bedfordshire"));
			country.Regions.Add(new Region("Z6", "Central Bedfordshire"));
			country.Regions.Add(new Region("Z7", "Cheshire East"));
			country.Regions.Add(new Region("Z8", "Cheshire West and Chester"));
			country.Regions.Add(new Region("Z9", "Isles of Scilly"));
			countryList.Add(country);

			// US Minor Outlying Islands -------------------------------------------------------------------
			//country = new Country("US Minor Outlying Islands", "UM");
			//countryList.Add(country);

			// Uruguay
			country = new Country("Uruguay", "UY");
			country.Regions.Add(new Region("01", "Artigas"));
			country.Regions.Add(new Region("02", "Canelones"));
			country.Regions.Add(new Region("03", "Cerro Largo"));
			country.Regions.Add(new Region("04", "Colonia"));
			country.Regions.Add(new Region("05", "Durazno"));
			country.Regions.Add(new Region("06", "Flores"));
			country.Regions.Add(new Region("07", "Florida"));
			country.Regions.Add(new Region("08", "Lavalleja"));
			country.Regions.Add(new Region("09", "Maldonado"));
			country.Regions.Add(new Region("10", "Montevideo"));
			country.Regions.Add(new Region("11", "Paysandu"));
			country.Regions.Add(new Region("12", "Rio Negro"));
			country.Regions.Add(new Region("13", "Rivera"));
			country.Regions.Add(new Region("14", "Rocha"));
			country.Regions.Add(new Region("15", "Salto"));
			country.Regions.Add(new Region("16", "San Jose"));
			country.Regions.Add(new Region("17", "Soriano"));
			country.Regions.Add(new Region("18", "Tacuarembo"));
			country.Regions.Add(new Region("19", "Treinta y Tres"));
			countryList.Add(country);

			// Uzbekistan
			country = new Country("Uzbekistan", "UZ");
			country.Regions.Add(new Region("01", "Andijon"));
			country.Regions.Add(new Region("02", "Bukhoro"));
			country.Regions.Add(new Region("03", "Farghona"));
			country.Regions.Add(new Region("04", "Jizzakh"));
			country.Regions.Add(new Region("05", "Khorazm"));
			country.Regions.Add(new Region("06", "Namangan"));
			country.Regions.Add(new Region("07", "Nawoiy"));
			country.Regions.Add(new Region("08", "Qashqadaryo"));
			country.Regions.Add(new Region("09", "Qoraqalpoghiston"));
			country.Regions.Add(new Region("10", "Samarqand"));
			country.Regions.Add(new Region("11", "Sirdaryo"));
			country.Regions.Add(new Region("12", "Surkhondaryo"));
			country.Regions.Add(new Region("13", "Toshkent"));
			country.Regions.Add(new Region("14", "Toshkent"));
			countryList.Add(country);

			// Vanuatu
			country = new Country("Vanuatu", "VU");
			country.Regions.Add(new Region("05", "Ambrym"));
			country.Regions.Add(new Region("06", "Aoba"));
			country.Regions.Add(new Region("07", "Torba"));
			country.Regions.Add(new Region("08", "Efate"));
			country.Regions.Add(new Region("09", "Epi"));
			country.Regions.Add(new Region("10", "Malakula"));
			country.Regions.Add(new Region("11", "Paama"));
			country.Regions.Add(new Region("12", "Pentecote"));
			country.Regions.Add(new Region("13", "Sanma"));
			country.Regions.Add(new Region("14", "Shepherd"));
			country.Regions.Add(new Region("15", "Tafea"));
			country.Regions.Add(new Region("16", "Malampa"));
			country.Regions.Add(new Region("17", "Penama"));
			country.Regions.Add(new Region("18", "Shefa"));
			countryList.Add(country);

			// Vatican City State (Holy See) -------------------------------------------------------------------
			//country = new Country("Vatican City State (Holy See)", "VA");
			//countryList.Add(country);

			// Venezuela
			country = new Country("Venezuela", "VE");
			country.Regions.Add(new Region("01", "Amazonas"));
			country.Regions.Add(new Region("02", "Anzoategui"));
			country.Regions.Add(new Region("03", "Apure"));
			country.Regions.Add(new Region("04", "Aragua"));
			country.Regions.Add(new Region("05", "Barinas"));
			country.Regions.Add(new Region("06", "Bolivar"));
			country.Regions.Add(new Region("07", "Carabobo"));
			country.Regions.Add(new Region("08", "Cojedes"));
			country.Regions.Add(new Region("09", "Delta Amacuro"));
			country.Regions.Add(new Region("11", "Falcon"));
			country.Regions.Add(new Region("12", "Guarico"));
			country.Regions.Add(new Region("13", "Lara"));
			country.Regions.Add(new Region("14", "Merida"));
			country.Regions.Add(new Region("15", "Miranda"));
			country.Regions.Add(new Region("16", "Monagas"));
			country.Regions.Add(new Region("17", "Nueva Esparta"));
			country.Regions.Add(new Region("18", "Portuguesa"));
			country.Regions.Add(new Region("19", "Sucre"));
			country.Regions.Add(new Region("20", "Tachira"));
			country.Regions.Add(new Region("21", "Trujillo"));
			country.Regions.Add(new Region("22", "Yaracuy"));
			country.Regions.Add(new Region("23", "Zulia"));
			country.Regions.Add(new Region("24", "Dependencias Federales"));
			country.Regions.Add(new Region("25", "Distrito Federal"));
			country.Regions.Add(new Region("26", "Vargas"));
			countryList.Add(country);

			// Vietnam
			country = new Country("Vietnam", "VN");
			country.Regions.Add(new Region("01", "An Giang"));
			country.Regions.Add(new Region("03", "Ben Tre"));
			country.Regions.Add(new Region("05", "Cao Bang"));
			country.Regions.Add(new Region("09", "Dong Thap"));
			country.Regions.Add(new Region("13", "Hai Phong"));
			country.Regions.Add(new Region("20", "Ho Chi Minh"));
			country.Regions.Add(new Region("21", "Kien Giang"));
			country.Regions.Add(new Region("23", "Lam Dong"));
			country.Regions.Add(new Region("24", "Long An"));
			country.Regions.Add(new Region("30", "Quang Ninh"));
			country.Regions.Add(new Region("32", "Son La"));
			country.Regions.Add(new Region("33", "Tay Ninh"));
			country.Regions.Add(new Region("34", "Thanh Hoa"));
			country.Regions.Add(new Region("35", "Thai Binh"));
			country.Regions.Add(new Region("37", "Tien Giang"));
			country.Regions.Add(new Region("39", "Lang Son"));
			country.Regions.Add(new Region("43", "Dong Nai"));
			country.Regions.Add(new Region("44", "Ha Noi"));
			country.Regions.Add(new Region("45", "Ba Ria-Vung Tau"));
			country.Regions.Add(new Region("46", "Binh Dinh"));
			country.Regions.Add(new Region("47", "Binh Thuan"));
			country.Regions.Add(new Region("49", "Gia Lai"));
			country.Regions.Add(new Region("50", "Ha Giang"));
			country.Regions.Add(new Region("52", "Ha Tinh"));
			country.Regions.Add(new Region("53", "Hoa Binh"));
			country.Regions.Add(new Region("54", "Khanh Hoa"));
			country.Regions.Add(new Region("55", "Kon Tum"));
			country.Regions.Add(new Region("58", "Nghe An"));
			country.Regions.Add(new Region("59", "Ninh Binh"));
			country.Regions.Add(new Region("60", "Ninh Thuan"));
			country.Regions.Add(new Region("61", "Phu Yen"));
			country.Regions.Add(new Region("62", "Quang Binh"));
			country.Regions.Add(new Region("63", "Quang Ngai"));
			country.Regions.Add(new Region("64", "Quang Tri"));
			country.Regions.Add(new Region("65", "Soc Trang"));
			country.Regions.Add(new Region("66", "Thua Thien-Hue"));
			country.Regions.Add(new Region("67", "Tra Vinh"));
			country.Regions.Add(new Region("68", "Tuyen Quang"));
			country.Regions.Add(new Region("69", "Vinh Long"));
			country.Regions.Add(new Region("70", "Yen Bai"));
			country.Regions.Add(new Region("71", "Bac Giang"));
			country.Regions.Add(new Region("72", "Bac Kan"));
			country.Regions.Add(new Region("73", "Bac Lieu"));
			country.Regions.Add(new Region("74", "Bac Ninh"));
			country.Regions.Add(new Region("75", "Binh Duong"));
			country.Regions.Add(new Region("76", "Binh Phuoc"));
			country.Regions.Add(new Region("77", "Ca Mau"));
			country.Regions.Add(new Region("78", "Da Nang"));
			country.Regions.Add(new Region("79", "Hai Duong"));
			country.Regions.Add(new Region("80", "Ha Nam"));
			country.Regions.Add(new Region("81", "Hung Yen"));
			country.Regions.Add(new Region("82", "Nam Dinh"));
			country.Regions.Add(new Region("83", "Phu Tho"));
			country.Regions.Add(new Region("84", "Quang Nam"));
			country.Regions.Add(new Region("85", "Thai Nguyen"));
			country.Regions.Add(new Region("86", "Vinh Phuc"));
			country.Regions.Add(new Region("87", "Can Tho"));
			country.Regions.Add(new Region("88", "Dac Lak"));
			country.Regions.Add(new Region("89", "Lai Chau"));
			country.Regions.Add(new Region("90", "Lao Cai"));
			country.Regions.Add(new Region("91", "Dak Nong"));
			country.Regions.Add(new Region("92", "Dien Bien"));
			country.Regions.Add(new Region("93", "Hau Giang"));
			countryList.Add(country);

			// Virgin Islands (British) -------------------------------------------------------------------
			country = new Country("Virgin Islands (British)", "VG");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Virgin Islands (US) -------------------------------------------------------------------
			country = new Country("Virgin Islands (US)", "VI");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Wallis and Futuna Islands -------------------------------------------------------------------
			country = new Country("Wallis and Futuna Islands", "WF");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Western Sahara -------------------------------------------------------------------
			country = new Country("Western Sahara", "EH");
			country.Regions.Add(new Region("0", string.Empty));
			countryList.Add(country);

			// Yemen
			country = new Country("Yemen", "YE");
			country.Regions.Add(new Region("01", "Abyan"));
			country.Regions.Add(new Region("02", "Adan"));
			country.Regions.Add(new Region("03", "Al Mahrah"));
			country.Regions.Add(new Region("04", "Hadramawt"));
			country.Regions.Add(new Region("05", "Shabwah"));
			country.Regions.Add(new Region("06", "Lahij"));
			country.Regions.Add(new Region("07", "Al Bayda'"));
			country.Regions.Add(new Region("08", "Al Hudaydah"));
			country.Regions.Add(new Region("09", "Al Jawf"));
			country.Regions.Add(new Region("10", "Al Mahwit"));
			country.Regions.Add(new Region("11", "Dhamar"));
			country.Regions.Add(new Region("12", "Hajjah"));
			country.Regions.Add(new Region("13", "Ibb"));
			country.Regions.Add(new Region("14", "Ma'rib"));
			country.Regions.Add(new Region("15", "Sa'dah"));
			country.Regions.Add(new Region("16", "San'a'"));
			country.Regions.Add(new Region("17", "Taizz"));
			country.Regions.Add(new Region("18", "Ad Dali"));
			country.Regions.Add(new Region("19", "Amran"));
			country.Regions.Add(new Region("20", "Al Bayda'"));
			country.Regions.Add(new Region("21", "Al Jawf"));
			country.Regions.Add(new Region("22", "Hajjah"));
			country.Regions.Add(new Region("23", "Ibb"));
			country.Regions.Add(new Region("24", "Lahij"));
			country.Regions.Add(new Region("25", "Taizz"));
			countryList.Add(country);

			// Zambia
			country = new Country("Zambia", "ZM");
			country.Regions.Add(new Region("01", "Western"));
			country.Regions.Add(new Region("02", "Central"));
			country.Regions.Add(new Region("03", "Eastern"));
			country.Regions.Add(new Region("04", "Luapula"));
			country.Regions.Add(new Region("05", "Northern"));
			country.Regions.Add(new Region("06", "North-Western"));
			country.Regions.Add(new Region("07", "Southern"));
			country.Regions.Add(new Region("08", "Copperbelt"));
			country.Regions.Add(new Region("09", "Lusaka"));
			countryList.Add(country);

			// Zimbabwe
			country = new Country("Zimbabwe", "ZW");
			country.Regions.Add(new Region("01", "Manicaland"));
			country.Regions.Add(new Region("02", "Midlands"));
			country.Regions.Add(new Region("03", "Mashonaland Central"));
			country.Regions.Add(new Region("04", "Mashonaland East"));
			country.Regions.Add(new Region("05", "Mashonaland West"));
			country.Regions.Add(new Region("06", "Matabeleland North"));
			country.Regions.Add(new Region("07", "Matabeleland South"));
			country.Regions.Add(new Region("08", "Masvingo"));
			country.Regions.Add(new Region("09", "Bulawayo"));
			country.Regions.Add(new Region("10", "Harare"));
			countryList.Add(country);

			return countryList;
		}

		//----------------------------------------

	} // End Class: GeoBus

} // End Namespace: Core.Business

//--------------------------------------------------------------------------------
// EOF
