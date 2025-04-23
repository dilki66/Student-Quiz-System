 public class Quiz
 {

     private List<Question> questions;
     private int score;
     private Random random;

public Quiz()
{
    questions = new List<Question>
  {
    new Question ("What is the capital of India?", "New Delhi"),
    new Question ("What is the largest planet in our solar system?", "Jupiter"),
    new Question ("Which is color of sky ?", "Blue"),
    new Question ("who found gravity ?", "niwton"),
    new Question ("current president in Sri Lanka ?", "Anura kumara")
  };

   score= 0;
   random = new Random();
}

 public void StartQuiz()
 {
    int questionAsked = 0;
    int totalQuestions = 3; 

    while(questionAsked < totalQuestions)
    {
      int index = random.Next(questions.Count);
      Question q = questions[index];

      Console.WriteLine($"Question  {questionAsked + 1} : {q.Text} ");
      Console.WriteLine("Your Answer : ");
      string studentAnswer = Console.ReadLine();

      if (studentAnswer.Trim().ToLower() == q.Answer.ToLower()){
        Console.WriteLine("correct");
        score++;
      }
       else{
        Console.WriteLine($"Wrong. Answer is {q.Answer}");
       }
       questionAsked++;
    }
      Console.WriteLine($" your score is {score} out of {totalQuestions} ");
 }




 }