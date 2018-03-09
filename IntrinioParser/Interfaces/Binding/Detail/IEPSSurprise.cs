namespace IntrinioParser.Interfaces.Binding.Detail
{
	internal interface IEPSSurprise : ISurprise
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