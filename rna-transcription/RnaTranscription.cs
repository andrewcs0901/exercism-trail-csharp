using System;
using System.Collections.Generic;
using System.Linq;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        Dictionary<char, char> rna = new Dictionary<char, char>
        {
            { 'G', 'C' },
            { 'C', 'G' },
            { 'T', 'A' },
            { 'A', 'U' }
        };
        return new string(nucleotide.ToCharArray().Select(ch => rna[ch]).ToArray());
    }
}