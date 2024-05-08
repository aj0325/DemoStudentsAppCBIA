using Demo.ApiClient;
using Demo.DemoCBIA.Models;
using System.Globalization;
namespace Demo.DemoCBIA.Pages;

public partial class AskQuestionsPage : ContentPage
{
    private readonly DemoApiClientService _apiClient;
    public AskQuestionsPage(DemoApiClientService apiClient)
	{
		InitializeComponent();

        _apiClient = apiClient;

        
        //PreviousQuestionsListView.ItemsSource = QuestionStorage.Questions;
    }

    private async void btnShowQuestions_Clicked(object sender, EventArgs e)
    {
        await LoadQuestions();
    }
    private async void btnAdd_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddQuestionPage(_apiClient, null));
    }

    private async void questionListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var question = (ApiClient.Models.ApiModels.Question)e.Item;
        var action = await DisplayActionSheet("Action", "Cancel", null, "Mark as solved", "Delete");

        switch (action)
        {
            case "Mark as solved":
                if (question.Solved)
                {
                    // Display an alert if the question is already marked as solved
                    await DisplayAlert("Alert", "This question is already marked as solved.", "OK");
                }
                else
                {
                    // Navigate to the AddQuestionPage if the question is not solved
                    await Navigation.PushModalAsync(new AddQuestionPage(_apiClient, question));
                }
                //await Navigation.PushModalAsync(new AddQuestionPage(_apiClient, question));
                break;
            case "Delete":
                await _apiClient.DeleteQuestion(question.Id);
                await LoadQuestions();
                break;
        }
    }

    private async Task LoadQuestions()
    {
        var question = await _apiClient.GetQuestions();
        questionsList.ItemsSource = question;
    }

    
}


