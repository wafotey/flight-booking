namespace FlightBooking.Domain.SharedKennel.Enumerations
{
    public class Country : Enumeration
    {
        public string Alpha2Code { get; private set; }
        public string Alpha3Code { get; private set; }
        public int NumericCode { get; private set; }
        public string CapitalCity { get; private set; }

        public Country(int id, string name, string alpha2Code, string alpha3Code, int numericCode, string capitalCity) : base(id, name)
        {
            Alpha2Code = alpha2Code;
            Alpha3Code = alpha3Code;
            NumericCode = numericCode;
            CapitalCity = capitalCity;
        }

    public static Country Afghanistan = new Country(1, "Afghanistan", "AF", "AFG", 004, "Kabul");
    public static Country Albania = new Country(2, "Albania", "AL", "ALB", 008, "Tirana");
    public static Country Algeria = new Country(3, "Algeria", "DZ", "DZA", 012, "Algiers");
    public static Country Andorra = new Country(4, "Andorra", "AD", "AND", 020, "Andorra la Vella");
    public static Country Angola = new Country(5, "Angola", "AO", "AGO", 024, "Luanda");
    public static Country AntiguaAndBarbuda = new Country(6, "Antigua and Barbuda", "AG", "ATG", 028, "St. John's");
    public static Country Argentina = new Country(7, "Argentina", "AR", "ARG", 032, "Buenos Aires");
    public static Country Armenia = new Country(8, "Armenia", "AM", "ARM", 051, "Yerevan");
    public static Country Australia = new Country(9, "Australia", "AU", "AUS", 036, "Canberra");
    public static Country Austria = new Country(10, "Austria", "AT", "AUT", 040, "Vienna");
    public static Country Azerbaijan = new Country(11, "Azerbaijan", "AZ", "AZE", 031, "Baku");

    public static Country Bahamas = new Country(12, "Bahamas", "BS", "BHS", 044, "Nassau");
    public static Country Bahrain = new Country(13, "Bahrain", "BH", "BHR", 048, "Manama");
    public static Country Bangladesh = new Country(14, "Bangladesh", "BD", "BGD", 050, "Dhaka");
    public static Country Barbados = new Country(15, "Barbados", "BB", "BRB", 052, "Bridgetown");
    public static Country Belarus = new Country(16, "Belarus", "BY", "BLR", 112, "Minsk");
    public static Country Belgium = new Country(17, "Belgium", "BE", "BEL", 056, "Brussels");
    public static Country Belize = new Country(18, "Belize", "BZ", "BLZ", 084, "Belmopan");
    public static Country Benin = new Country(19, "Benin", "BJ", "BEN", 204, "Porto-Novo");
    public static Country Bhutan = new Country(20, "Bhutan", "BT", "BTN", 064, "Thimphu");
    public static Country Bolivia = new Country(21, "Bolivia", "BO", "BOL", 068, "Sucre");
    public static Country BosniaAndHerzegovina = new Country(22, "Bosnia and Herzegovina", "BA", "BIH", 070, "Sarajevo");

    public static Country Botswana = new Country(23, "Botswana", "BW", "BWA", 072, "Gaborone");
    public static Country Brazil = new Country(24, "Brazil", "BR", "BRA", 076, "Brasília");
    public static Country Brunei = new Country(25, "Brunei Darussalam", "BN", "BRN", 096, "Bandar Seri Begawan");
    public static Country Bulgaria = new Country(26, "Bulgaria", "BG", "BGR", 100, "Sofia");
    public static Country BurkinaFaso = new Country(27, "Burkina Faso", "BF", "BFA", 854, "Ouagadougou");
    public static Country Burundi = new Country(28, "Burundi", "BI", "BDI", 108, "Bujumbura");
    public static Country CaboVerde = new Country(29, "Cabo Verde", "CV", "CPV", 132, "Praia");
    public static Country Cambodia = new Country(30, "Cambodia", "KH", "KHM", 116, "Phnom Penh");
    public static Country Cameroon = new Country(31, "Cameroon", "CM", "CMR", 120, "Yaoundé");

    public static Country Canada = new Country(32, "Canada", "CA", "CAN", 124, "Ottawa");
    public static Country CentralAfricanRepublic = new Country(33, "Central African Republic", "CF", "CAF", 140, "Bangui");
    public static Country Chad = new Country(34, "Chad", "TD", "TCD", 148, "N'Djamena");
    public static Country Chile = new Country(35, "Chile", "CL", "CHL", 152, "Santiago");
    public static Country China = new Country(36, "China", "CN", "CHN", 156, "Beijing");
    public static Country Colombia = new Country(37, "Colombia", "CO", "COL", 170, "Bogotá");
    public static Country Comoros = new Country(38, "Comoros", "KM", "COM", 174, "Moroni");
    public static Country Congo = new Country(39, "Congo (Republic of the Congo)", "CG", "COG", 178, "Brazzaville");
    public static Country CostaRica = new Country(40, "Costa Rica", "CR", "CRI", 188, "San José");
    public static Country Croatia = new Country(41, "Croatia", "HR", "HRV", 191, "Zagreb");

    public static Country Cuba = new Country(42, "Cuba", "CU", "CUB", 192, "Havana");
    public static Country Cyprus = new Country(43, "Cyprus", "CY", "CYP", 196, "Nicosia");
    public static Country CzechRepublic = new Country(44, "Czech Republic", "CZ", "CZE", 203, "Prague");
    public static Country DemocraticRepublicOfCongo = new Country(45, "Democratic Republic of the Congo", "CD", "COD", 180, "Kinshasa");
    public static Country Denmark = new Country(46, "Denmark", "DK", "DNK", 208, "Copenhagen");
    public static Country Djibouti = new Country(47, "Djibouti", "DJ", "DJI", 262, "Djibouti");
    public static Country Dominica = new Country(48, "Dominica", "DM", "DMA", 212, "Roseau");
    public static Country DominicanRepublic = new Country(49, "Dominican Republic", "DO", "DOM", 214, "Santo Domingo");
    public static Country Ecuador = new Country(50, "Ecuador", "EC", "ECU", 218, "Quito");
    public static Country Egypt = new Country(51, "Egypt", "EG", "EGY", 818, "Cairo");

    public static Country ElSalvador = new Country(52, "El Salvador", "SV", "SLV", 222, "San Salvador");
    public static Country EquatorialGuinea = new Country(53, "Equatorial Guinea", "GQ", "GNQ", 226, "Malabo");
    public static Country Eritrea = new Country(54, "Eritrea", "ER", "ERI", 232, "Asmara");
    public static Country Estonia = new Country(55, "Estonia", "EE", "EST", 233, "Tallinn");
    public static Country Eswatini = new Country(56, "Eswatini", "SZ", "SWZ", 748, "Mbabane");
    public static Country Ethiopia = new Country(57, "Ethiopia", "ET", "ETH", 231, "Addis Ababa");
    public static Country Fiji = new Country(58, "Fiji", "FJ", "FJI", 242, "Suva");
    public static Country Finland = new Country(59, "Finland", "FI", "FIN", 246, "Helsinki");
    public static Country France = new Country(60, "France", "FR", "FRA", 250, "Paris");
    public static Country Gabon = new Country(61, "Gabon", "GA", "GAB", 266, "Libreville");
    public static Country Gambia = new Country(62, "Gambia", "GM", "GMB", 270, "Banjul");
    public static Country Georgia = new Country(63, "Georgia", "GE", "GEO", 268, "Tbilisi");
    public static Country Germany = new Country(64, "Germany", "DE", "DEU", 276, "Berlin");
    public static Country Ghana = new Country(65, "Ghana", "GH", "GHA", 288, "Accra");
    public static Country Greece = new Country(66, "Greece", "GR", "GRC", 300, "Athens");
    public static Country Grenada = new Country(67, "Grenada", "GD", "GRD", 308, "St. George's");
    public static Country Guatemala = new Country(68, "Guatemala", "GT", "GTM", 320, "Guatemala City");
    public static Country Guinea = new Country(69, "Guinea", "GN", "GIN", 324, "Conakry");
    public static Country GuineaBissau = new Country(70, "Guinea-Bissau", "GW", "GNB", 624, "Bissau");

    public static Country Guyana = new Country(71, "Guyana", "GY", "GUY", 328, "Georgetown");
    public static Country Haiti = new Country(72, "Haiti", "HT", "HTI", 332, "Port-au-Prince");
    public static Country Honduras = new Country(73, "Honduras", "HN", "HND", 340, "Tegucigalpa");
    public static Country Hungary = new Country(74, "Hungary", "HU", "HUN", 348, "Budapest");
    public static Country Iceland = new Country(75, "Iceland", "IS", "ISL", 352, "Reykjavík");
    public static Country India = new Country(76, "India", "IN", "IND", 356, "New Delhi");
    public static Country Indonesia = new Country(77, "Indonesia", "ID", "IDN", 360, "Jakarta");
    public static Country Iran = new Country(78, "Iran", "IR", "IRN", 364, "Tehran");
    public static Country Iraq = new Country(79, "Iraq", "IQ", "IRQ", 368, "Baghdad");
    public static Country Ireland = new Country(80, "Ireland", "IE", "IRL", 372, "Dublin");

    public static Country Israel = new Country(81, "Israel", "IL", "ISR", 376, "Jerusalem");
    public static Country Italy = new Country(82, "Italy", "IT", "ITA", 380, "Rome");
    public static Country Jamaica = new Country(83, "Jamaica", "JM", "JAM", 388, "Kingston");
    public static Country Japan = new Country(84, "Japan", "JP", "JPN", 392, "Tokyo");
    public static Country Jordan = new Country(85, "Jordan", "JO", "JOR", 400, "Amman");
    public static Country Kazakhstan = new Country(86, "Kazakhstan", "KZ", "KAZ", 398, "Astana");
    public static Country Kenya = new Country(87, "Kenya", "KE", "KEN", 404, "Nairobi");
    public static Country Kiribati = new Country(88, "Kiribati", "KI", "KIR", 296, "South Tarawa");
    public static Country KoreaNorth = new Country(89, "North Korea", "KP", "PRK", 408, "Pyongyang");
    public static Country KoreaSouth = new Country(90, "South Korea", "KR", "KOR", 410, "Seoul");

    public static Country Kuwait = new Country(91, "Kuwait", "KW", "KWT", 414, "Kuwait City");
    public static Country Kyrgyzstan = new Country(92, "Kyrgyzstan", "KG", "KGZ", 417, "Bishkek");
    public static Country Laos = new Country(93, "Laos", "LA", "LAO", 418, "Vientiane");
    public static Country Latvia = new Country(94, "Latvia", "LV", "LVA", 428, "Riga");
    public static Country Lebanon = new Country(95, "Lebanon", "LB", "LBN", 422, "Beirut");
    public static Country Lesotho = new Country(96, "Lesotho", "LS", "LSO", 426, "Maseru");
    public static Country Liberia = new Country(97, "Liberia", "LR", "LBR", 430, "Monrovia");
    public static Country Libya = new Country(98, "Libya", "LY", "LBY", 434, "Tripoli");
    public static Country Liechtenstein = new Country(99, "Liechtenstein", "LI", "LIE", 438, "Vaduz");
    public static Country Lithuania = new Country(100, "Lithuania", "LT", "LTU", 440, "Vilnius");

    public static Country Luxembourg = new Country(101, "Luxembourg", "LU", "LUX", 442, "Luxembourg City");
    public static Country Madagascar = new Country(102, "Madagascar", "MG", "MDG", 450, "Antananarivo");
    public static Country Malawi = new Country(103, "Malawi", "MW", "MWI", 454, "Lilongwe");
    public static Country Malaysia = new Country(104, "Malaysia", "MY", "MYS", 458, "Kuala Lumpur");
    public static Country Maldives = new Country(105, "Maldives", "MV", "MDV", 462, "Malé");
    public static Country Mali = new Country(106, "Mali", "ML", "MLI", 466, "Bamako");
    public static Country Malta = new Country(107, "Malta", "MT", "MLT", 470, "Valletta");
    public static Country MarshallIslands = new Country(108, "Marshall Islands", "MH", "MHL", 584, "Majuro");
    public static Country Mauritania = new Country(109, "Mauritania", "MR", "MRT", 478, "Nouakchott");
    public static Country Mauritius = new Country(110, "Mauritius", "MU", "MUS", 480, "Port Louis");

    public static Country Mexico = new Country(111, "Mexico", "MX", "MEX", 484, "Mexico City");
    public static Country Micronesia = new Country(112, "Micronesia", "FM", "FSM", 583, "Palikir");
    public static Country Moldova = new Country(113, "Moldova", "MD", "MDA", 498, "Chisinau");
    public static Country Monaco = new Country(114, "Monaco", "MC", "MCO", 492, "Monaco");
    public static Country Mongolia = new Country(115, "Mongolia", "MN", "MNG", 496, "Ulaanbaatar");
    public static Country Montenegro = new Country(116, "Montenegro", "ME", "MNE", 499, "Podgorica");
    public static Country Morocco = new Country(117, "Morocco", "MA", "MAR", 504, "Rabat");
    public static Country Mozambique = new Country(118, "Mozambique", "MZ", "MOZ", 508, "Maputo");
    public static Country Myanmar = new Country(119, "Myanmar", "MM", "MMR", 104, "Naypyidaw");
    public static Country Namibia = new Country(120, "Namibia", "NA", "NAM", 516, "Windhoek");

     public static Country SaintKittsAndNevis = new Country(121, "Saint Kitts and Nevis", "KN", "KNA", 659, "Basseterre");
    public static Country SaintLucia = new Country(122, "Saint Lucia", "LC", "LCA", 662, "Castries");
    public static Country SaintVincentAndTheGrenadines = new Country(123, "Saint Vincent and the Grenadines", "VC", "VCT", 670, "Kingstown");
    public static Country Samoa = new Country(124, "Samoa", "WS", "WSM", 882, "Apia");
    public static Country SanMarino = new Country(125, "San Marino", "SM", "SMR", 674, "San Marino");
    public static Country SaoTomeAndPrincipe = new Country(126, "São Tomé and Príncipe", "ST", "STP", 678, "São Tomé");
    public static Country SaudiArabia = new Country(127, "Saudi Arabia", "SA", "SAU", 682, "Riyadh");
    public static Country Senegal = new Country(128, "Senegal", "SN", "SEN", 686, "Dakar");
    public static Country Serbia = new Country(129, "Serbia", "RS", "SRB", 688, "Belgrade");
    public static Country Seychelles = new Country(130, "Seychelles", "SC", "SYC", 690, "Victoria");

    public static Country SierraLeone = new Country(131, "Sierra Leone", "SL", "SLE", 694, "Freetown");
    public static Country Singapore = new Country(132, "Singapore", "SG", "SGP", 702, "Singapore");
    public static Country Slovakia = new Country(133, "Slovakia", "SK", "SVK", 703, "Bratislava");
    public static Country Slovenia = new Country(134, "Slovenia", "SI", "SVN", 705, "Ljubljana");
    public static Country SolomonIslands = new Country(135, "Solomon Islands", "SB", "SLB", 090, "Honiara");
    public static Country Somalia = new Country(136, "Somalia", "SO", "SOM", 706, "Mogadishu");
    public static Country SouthAfrica = new Country(137, "South Africa", "ZA", "ZAF", 710, "Pretoria");
    public static Country SouthSudan = new Country(138, "South Sudan", "SS", "SSD", 728, "Juba");
    public static Country Spain = new Country(139, "Spain", "ES", "ESP", 724, "Madrid");
    public static Country SriLanka = new Country(140, "Sri Lanka", "LK", "LKA", 144, "Colombo");

    public static Country Sudan = new Country(141, "Sudan", "SD", "SDN", 736, "Khartoum");
    public static Country Suriname = new Country(142, "Suriname", "SR", "SUR", 740, "Paramaribo");
    public static Country Sweden = new Country(143, "Sweden", "SE", "SWE", 752, "Stockholm");
    public static Country Switzerland = new Country(144, "Switzerland", "CH", "CHE", 756, "Bern");
    public static Country Syria = new Country(145, "Syria", "SY", "SYR", 760, "Damascus");
    public static Country Taiwan = new Country(146, "Taiwan", "TW", "TWN", 158, "Taipei");
    public static Country Tajikistan = new Country(147, "Tajikistan", "TJ", "TJK", 762, "Dushanbe");
    public static Country Tanzania = new Country(148, "Tanzania", "TZ", "TZA", 834, "Dodoma");
    public static Country Thailand = new Country(149, "Thailand", "TH", "THA", 764, "Bangkok");
    public static Country Togo = new Country(150, "Togo", "TG", "TGO", 768, "Lomé");

    public static Country Tonga = new Country(151, "Tonga", "TO", "TON", 776, "Nuku'alofa");
    public static Country TrinidadAndTobago = new Country(152, "Trinidad and Tobago", "TT", "TTO", 780, "Port of Spain");
    public static Country Tunisia = new Country(153, "Tunisia", "TN", "TUN", 788, "Tunis");
    public static Country Turkey = new Country(154, "Turkey", "TR", "TUR", 792, "Ankara");
    public static Country Turkmenistan = new Country(155, "Turkmenistan", "TM", "TKM", 795, "Ashgabat");
    public static Country Tuvalu = new Country(156, "Tuvalu", "TV", "TUV", 798, "Funafuti");
    public static Country Uganda = new Country(157, "Uganda", "UG", "UGA", 800, "Kampala");
    public static Country Ukraine = new Country(158, "Ukraine", "UA", "UKR", 804, "Kyiv");
    public static Country UnitedArabEmirates = new Country(159, "United Arab Emirates", "AE", "ARE", 784, "Abu Dhabi");
    public static Country UnitedKingdom = new Country(160, "United Kingdom", "GB", "GBR", 826, "London");
    public static Country UnitedStates = new Country(161, "United States", "US", "USA", 840, "Washington, D.C.");

    public static Country Uruguay = new Country(162, "Uruguay", "UY", "URY", 858, "Montevideo");
    public static Country Uzbekistan = new Country(163, "Uzbekistan", "UZ", "UZB", 860, "Tashkent");
    public static Country Vanuatu = new Country(164, "Vanuatu", "VU", "VUT", 548, "Port Vila");
    public static Country VaticanCity = new Country(165, "Vatican City", "VA", "VAT", 336, "Vatican City");
    public static Country Venezuela = new Country(166, "Venezuela", "VE", "VEN", 862, "Caracas");
    public static Country Vietnam = new Country(167, "Vietnam", "VN", "VNM", 704, "Hanoi");
    public static Country Yemen = new Country(168, "Yemen", "YE", "YEM", 887, "Sana'a");
    public static Country Zambia = new Country(169, "Zambia", "ZM", "ZMB", 894, "Lusaka");
    public static Country Zimbabwe = new Country(170, "Zimbabwe", "ZW", "ZWE", 716, "Harare");
    public static Country HolySee = new Country(171, "Holy See", "VA", "VAT", 336, "Vatican City");
    public static Country Palestine = new Country(172, "Palestine", "PS", "PSE", 275, "Ramallah");
    
    }
}
        