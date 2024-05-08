using Demo.DemoCBIA.Models;
namespace Demo.DemoCBIA.Pages;

public partial class QuestionSubmissionPage : ContentPage
{
	public QuestionSubmissionPage()
	{
		InitializeComponent();
	}

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        string studentId = StudentIdEntry.Text;
        string studentName = StudentNameEntry.Text;
        string questionText = QuestionEntry.Text;

        // You can add validation here before adding the question
        QuestionStorage.AddQuestion(studentId, studentName, questionText);
        await Navigation.PopAsync(); // Go back to the previous page
    }
}