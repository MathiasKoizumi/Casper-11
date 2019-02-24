namespace WindowsFormsApplication1
{
	internal class Spaceship1
	{
		private Form1 form1;

		public Spaceship1(Form1 form1)
		{
			this.form1 = form1;
			form1.landingIsHere(200);
			form1.burnRubber(2000.0, 1000f, 50);
			form1.WalkAroundSpaceman();
			form1.BlackStrangeSpellOut(100);
			for (int i = 0; i < form1.junkie.Next(10); i++)
			{
				form1.wierdoFuckMe(form1.junkie.Next(3, 6));
			}
		}
	}
}
