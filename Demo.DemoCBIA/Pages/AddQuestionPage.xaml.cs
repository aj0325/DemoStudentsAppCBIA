using Demo.ApiClient;
using Demo.ApiClient.Models.ApiModels;

namespace Demo.DemoCBIA.Pages;

public partial class AddQuestionPage : ContentPage
{
    private readonly DemoApiClientService _apiClient;
    private Question _question;
    public AddQuestionPage(DemoApiClientService apiClient, Question question)
    {
        InitializeComponent();

        _apiClient = apiClient;
        _question = question;
        LoadQuestionDetails();
    }
    private void LoadQuestionDetails()
    {
        if (_question is not null)
        {
            txtSId.Text = _question.StudentId.ToString();
            dpDate.Date = _question.Date;
            txtQuestion.Text = _question.QuestionAsked;
            //txtAnswer.Text = _question.Answer;
            swSolved.IsChecked = _question.Solved;
        }
    }

    private async void btnSave_Clicked(object sender, EventArgs e)
    {
        if (_question is null)
        {
            // Add a new cultural event
            await _apiClient.SaveQuestion(new Question
            {
                StudentId = _question.StudentId,
                QuestionAsked = txtQuestion.Text,
                Date = dpDate.Date,
                Answer = "",
                Solved = swSolved.IsChecked
            }) ;
        }
        else
        {
            // Update an existing cultural event
            await _apiClient.UpdateQuestion(new Question
            {
                Id = _question.Id,
                StudentId = _question.StudentId,
                QuestionAsked = _question.QuestionAsked,
                Date = _question.Date,
                Answer = _question.Answer,
                Solved = swSolved.IsChecked
            });
        }

        await Navigation.PopModalAsync();
    }
    private async void btnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}