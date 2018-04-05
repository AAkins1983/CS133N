calculateButton
	{
		try
		{
			// Local variables
			decimal begBalance;		// To hold beginning balance
			decimal credits;		// To hold credits
			decimal charges;		// To hold charges
			decimal creditLimit;	// To hold creditLimit
		
			// Get beginning balance, credits, charges, and credit limit.
			begBalance = decimal.Parse(begBalTextbox.Text);
			credits = decimal.Parse(creditsTextbox.Text);
			charges = decimal.Parse(chargesTextbox.Text);
			credits = decimal.Parse(creditsTextbox.Text);
			creditLimit = decimal.Parse(creditLimitTextbox.Text);
		
			// Determine end balance.
			endBalance = begBalance + charges - credits;
			lblEndBalance.Text = endBalance.ToString("c");
		
			if (endBalance > creditLimit)
			{
				// Display default error message.
				MessageBox.Show("Credit limit exceeded.");
			}
		}
		catch (Exception ex)
		{
			// Display default error message.
			MessageBox.Show(ex.Message);
		}
	}
