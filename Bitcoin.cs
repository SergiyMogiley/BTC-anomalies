using Microsoft.ML.Data;
// </SnippetAddUsing>

namespace BitcoinAnomalyDetection
{
    // <SnippetDeclareTypes>
    public class BitcoinData
    {
        [LoadColumn(0)]
        public string Month;

        [LoadColumn(1)]
        public float numSales;
    }

    public class BitcoinPrediction
    {
        //vector to hold alert,score,p-value values
        [VectorType(3)]
        public double[] Prediction { get; set; }
    }
    // </SnippetDeclareTypes>
}