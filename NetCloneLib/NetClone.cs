using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCloneLib
{
    public static class NetClone
    {
        public static List<NetCloneUserTest> UserTestCloneCreate(this IEnumerable<DALTestingSystemDB.UserTest> list)
        {
            List<NetCloneUserTest> result = new List<NetCloneUserTest>();
            if(list != null)
            {
                foreach (var item in list)
                {
                    NetCloneUserTest netCloneUserTest = new NetCloneUserTest();
                    netCloneUserTest.Id = item.Id;
                    //User
                    netCloneUserTest.User = new NetCloneUser()
                    {
                        Id = item.User.Id,
                        FirstName = String.Copy(item.User.FirstName),
                        LastName = String.Copy(item.User.LastName),
                        Login = String.Copy(item.User.Login)
                    };

                    //Test - Question - Answer, userAnswer
                    netCloneUserTest.Test = new NetCloneTest()
                    {
                        Id = item.Test.Id,
                        Title = String.Copy(item.Test.Title),
                        Author = String.Copy(item.Test.Author),
                        Description = String.Copy(item.Test.Description),
                        Info = String.Copy(item.Test.Info),
                        PassPercent = item.Test.PassPercent
                    };

                    List<NetCloneQuestion> questions = new List<NetCloneQuestion>();
                    foreach (var q in item.Test.Questions)
                    {
                        NetCloneQuestion question = new NetCloneQuestion()
                        {
                            Id = q.Id,
                            QuestionText = String.Copy(q.QuestionText),
                            Img = item.IsTaked ? String.Empty : String.Copy(q.Img),
                            Points = q.Points,
                        };

                        List<NetCloneAnswer> answers = new List<NetCloneAnswer>();
                        List<NetCloneUserAnswer> userAnswers = new List<NetCloneUserAnswer>();
                        foreach (var a in q.Answers)
                        {
                            NetCloneAnswer answer = (new NetCloneAnswer()
                            {
                                Id = a.Id,
                                AnswerText = String.Copy(a.AnswerText),
                                CountRight = q.Answers.Where(x => x.IsRight == true).Count()
                            });

                            NetCloneUserAnswer userAnswer = new NetCloneUserAnswer()
                            {
                                Id = item.UserAnswers.FirstOrDefault(x => x.Answer.Id == a.Id).Id,
                                IsChecked = item.UserAnswers.FirstOrDefault(x => x.Answer.Id == a.Id).IsChecked,
                                Answer = answer
                            };
                            answers.Add(answer);
                            userAnswers.Add(userAnswer);
                        }
                        questions.Add(question);
                    }
                    netCloneUserTest.Test.Questions = questions;
                    netCloneUserTest.PointsGrade = item.PointsGrade;
                    netCloneUserTest.IsPassed = item.IsPassed;
                    netCloneUserTest.TakedDate = item.TakedDate;
                    netCloneUserTest.IsTaked = item.IsTaked;

                    result.Add(netCloneUserTest);
                }
            }           

            return result;            
        }
    }
}
