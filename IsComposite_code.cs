private bool IsComposite (int someNumber)
{
	composite = false;
	
	if (someNumber = 1)
	{
		composite = false;
	}
	else if (someNumber = 2)
	{
		composite = false;
	}
	else
	{
		divisor = 2;
		while (divisor < someNumber && composite == false)
		{
			if (someNumber % divisor)
			{
				composite = true;
			}
			else
			{
				divisor = divisor + 1;
			}
		}
	}
	
	return composite;
}

try
{
	int upperlimit;
	
	compositeListBox.Items.Clear();
	upperLimit = int.Parse(limitTextBox.Text);
	
	for (int count = 1; count <= upperLimit; count++)
	{
		if IsComposite(count))
		{
			compositeListBox.Items.Add(count.ToString());
		}
	}
	catch (Exception ex)
	{
		MessageBox.Show(ex.Message)
	}
	
	StreamWriter outputFile;
	if (saveFileDialog.ShowDialog() == DialogResult.OK)
	{
		outputFile = File.CreateText(saveFileDialog.FileName);
		
		for (int index = 0; index < compositeListBox.Items.Count; index++)
		{
			compositeListBox.SelectedIndex = index;
			outputFile.WriteLine(compositeListBox.SelectedItem);
		}
		
		outputFile.Close();
		MessageBox.Show("The data was saved.");
	}
	else
	{
		MessageBox.Show("The Save Dialog Box was cancelled.");
	}
}