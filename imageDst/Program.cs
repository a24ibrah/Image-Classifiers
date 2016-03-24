using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace imageDst
{
    class Program
    {
        static void Main(string[] args)
        {
         
            var distanceM = new manhattanDistance();
            var distanceE = new euclideanDistance();

            var classifierM = new BasicClassifier(distanceM);
            var classifierE = new BasicClassifier(distanceE);

            var trainingPath = @"C:\Users\ahmed\Documents\Visual Studio 2013\Projects\imageDst\trainingsample.csv";
            var training = DataReader.ReadObservations(trainingPath);
            classifierM.Train(training);
            classifierE.Train(training);

            var validationPath = @"C:\Users\ahmed\Documents\Visual Studio 2013\Projects\imageDst\validationsample.csv";
            var validation = DataReader.ReadObservations(validationPath);
            var correctM = Evaluator.Correct(validation, classifierM);
            var correctE = Evaluator.Correct(validation, classifierE);

            Console.WriteLine("Correctly classified: {0:P2}", correctM);
            Console.WriteLine("Correctly classified: {0:P2}", correctE);

            Console.ReadLine();
        }
    }

   

}
