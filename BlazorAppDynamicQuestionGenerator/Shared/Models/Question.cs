﻿using System;
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

    public string CorrectAnswer { get; set; }



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

public class CheckBoxOptions
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? ImagePath { get; set; }
}
public class CheckBoxAnswerOptions
{
    public int Id { get; set; }
    public bool value { get; set; }
}
