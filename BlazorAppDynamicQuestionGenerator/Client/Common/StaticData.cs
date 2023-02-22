using BlazorAppDynamicQuestionGenerator.Shared.Models;

namespace BlazorAppDynamicQuestionGenerator.Client.Common;

public static class StaticData
{
    public static string[] answerOptionsName = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" };
    public static List<AnswerType> multipuleChoiceOptionsList()
    {
        List<AnswerType> answerType = new List<AnswerType>();
        answerType.Add(new AnswerType { Id = 1, UniqueCode = "MultipuleChoice", Name = "Multipule Choice", ImagePath = "" });
        answerType.Add(new AnswerType { Id = 2, UniqueCode = "Checkboxes", Name = "Checkboxes", ImagePath = "" });
        answerType.Add(new AnswerType { Id = 3, UniqueCode = "TrueFalse", Name = "True False", ImagePath = "" });
        answerType.Add(new AnswerType { Id = 4, UniqueCode = "FullForm", Name = "Full Form", ImagePath = "" });
        answerType.Add(new AnswerType { Id = 5, UniqueCode = "FillInBlanks", Name = "Fill In Blanks", ImagePath = "" });
        answerType.Add(new AnswerType { Id = 6, UniqueCode = "ShortAnswer", Name = "Short Answer", ImagePath = "" });
        answerType.Add(new AnswerType { Id = 7, UniqueCode = "Paragraph", Name = "Paragraph", ImagePath = "" });
        return answerType;
    }
}
