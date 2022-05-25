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
                    //UserTest object
                    NetCloneUserTest userTest = new NetCloneUserTest()
                    {
                        Id = item.Id,
                        PointsGrade = item.PointsGrade,
                        IsPassed = item.IsPassed,
                        TakedDate = item.TakedDate,
                        IsTaked = item.IsTaked,
                    };

                    //User
                    userTest.User = new NetCloneUser()
                    {
                        Id = item.User.Id,
                        FirstName = String.Copy(item.User.FirstName),
                        LastName = String.Copy(item.User.LastName),
                        Login = String.Copy(item.User.Login)
                    };

                    //Test - Question - Answer, userAnswer
                    userTest.Test = new NetCloneTest()
                    {
                        Id = item.Test.Id,
                        Title = String.Copy(item.Test.Title),
                        Author = String.Copy(item.Test.Author),
                        Description = String.Copy(item.Test.Description),
                        Info = String.Copy(item.Test.Info),
                        PassPercent = item.Test.PassPercent, 
                        Questions = new List<NetCloneQuestion>()
                    };

                    foreach (var q in item.Test.Questions)
                    {
                        NetCloneQuestion question = new NetCloneQuestion()
                        {
                            Id = q.Id,
                            QuestionText = String.Copy(q.QuestionText),
                            Img = item.IsTaked ? String.Empty : String.Copy(q.Img),
                            Points = q.Points,
                            CountRight = q.Answers.Where(x => x.IsRight == true).Count(),
                            Answers = new List<NetCloneAnswer>()
                        };

                        foreach (var a in q.Answers)
                        {
                            NetCloneAnswer answer = (new NetCloneAnswer()
                            {
                                Id = a.Id,
                                AnswerText = String.Copy(a.AnswerText),
                                IdUserAnswer = item.UserAnswers.FirstOrDefault(x => x.Answer.Id == a.Id).Id,
                                IsChecked = item.UserAnswers.FirstOrDefault(x => x.Answer.Id == a.Id).IsChecked
                            });
                            question.Answers.Add(answer);
                        }
                        userTest.Test.Questions.Add(question);
                    }
                    result.Add(userTest);
                }
            }  
            return result;            
        }
    }
}
