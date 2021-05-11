 


namespace CeQueVousNeSavezPasSur.CSharp.T4Templates
{
	public static class BasicMapper
	{
		public static PolirisClassified Map(Classified classified)
		{
			var poliris = new PolirisClassified();
			poliris.Identifier = classified.Id.ToString();
			poliris.Parkings_Nb = classified.NumberOfParkings.ToString();
			poliris.RoomsNb = classified.Shop.NumberOfRooms.ToString();
						
			return poliris;
		}
	}
}