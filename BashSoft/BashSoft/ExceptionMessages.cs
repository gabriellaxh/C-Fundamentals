using System;
using System.Collections.Generic;
using System.Text;

namespace BashSoft
{
    public static class ExceptionMessages
    {
        public const string DataAlreadyInitializedExceptionMessage = "Data is already initialized!";
        public const string DataNotInitializedExceptionMessage = "The data structure must be initialized first in order to make any operations with it.";
        public const string InexistingCourseInDataBaseExceptionMessage = "The course you are trying to get does not exist in the data base!";
        public const string InvalidPathExceptionMessage = "The folder/file you are trying to access at the current address, does not exist.";
        public const string UnauthorizedAccessExceptionMessage = "The folder/file you are trying to get access needs a higher level of rights than you currently have.";
        public const string ComparisonOfFilesWithDifferentSizesExceptionMessage = "Files not of equal size, certain mismatch.";
        public const string ForbiddenSymbolContainedInNameExceptionMessage = "The given name contains symbols that are not allowed to be used in names of files and folders.";
        public const string UnableToGoHigherInPArtitionHierarchyExceptionMessage = "";
        public const string UnableToParseNumberExceptionMessage = "The sequence you've written is not a valid number.";
        public const string InvalidStudentFilter = "The given filter is not one of the following: excellent/average/poor";
        public const string InvalidComparisonQuery = "The comparison query you want, does not exist in the context of the current program!";
        public const string InvalidTakeQuantityParameter = "The take command expected does not match the format wanted!";
    }
}
