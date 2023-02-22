using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppDynamicQuestionGenerator.Shared.Models;

public class Question
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? ImagePath { get; set; }
    public string Answer { get; set; }

    public int AnswerTypeId { get; set; }
    public virtual AnswerType AnswerType { get; set; }

    public int CorrectAnswer { get; set; }



}

public class AnswerType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string UniqueCode { get; set; }
    public string? ImagePath { get; set; }
}

public class MultipuleChoiceOptions
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? ImagePath { get; set; }
}
public class UploadedFile
{
    public string FileName { get; set; }
    public byte[] FileContent { get; set; }
}

