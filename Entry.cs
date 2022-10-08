using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Lab2Solution
{
    public class Entry : ObservableObject
    {

        const int MAX_DIFFICULTY = 2;
        String clue;
        String answer;
        int difficulty;
        String date;
        int id; 

        public String Clue
        {
            get { return clue; }
            set { SetProperty(ref clue, value); }
        }

        public String Answer
        {
            get { return answer; }
            set { SetProperty(ref answer, value); }
        }

        public int Difficulty
        {
            get { return difficulty; }
            set
            {
                if (value <= MAX_DIFFICULTY && value >= 0)
                {
                    SetProperty(ref difficulty, value);
                }
            }
        }

        public String Date
        {
            get { return date;  }
            set { SetProperty(ref date, value); }
        }

        public int Id
        {
            get { return id;  }
            set { SetProperty(ref id, value); }
        }

        public Entry(String clue, String answer, int difficulty, String date, int id)
        {
            this.clue = clue;
            this.answer = answer;
            this.difficulty = difficulty;
            this.date = date;
            this.id = id;
        }

    }
}

