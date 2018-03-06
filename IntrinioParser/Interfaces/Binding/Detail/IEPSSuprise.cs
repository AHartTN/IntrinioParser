namespace IntrinioParser.Interfaces.Binding.Detail {
	internal interface IEPSSuprise : ISuprise
	{
		decimal? EPSActual { get; set; }
		decimal? EPSActualZacksAdj { get; set; }
		decimal? EPSMeanEstimate { get; set; }
		decimal? EPSAmountDiff { get; set; }
		decimal? EPSPercentDiff { get; set; }
		decimal? EPSCountEstimate { get; set; }
		decimal? EPSStdDevEstimate { get; set; }
	}
}