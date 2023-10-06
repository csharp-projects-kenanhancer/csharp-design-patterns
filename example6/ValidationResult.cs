namespace Example6;

public class ValidationResult
{
    public bool IsValid { get; private set; } = true;
    private readonly List<string> _errors = new List<string>();
    public IReadOnlyList<string> Errors => _errors.AsReadOnly();
    public string ErrorMessage => string.Join("\n", Errors);

    public void AddError(string error)
    {
        IsValid = false;
        _errors.Add(error);
    }

    public void Merge(ValidationResult other)
    {
        if (other.IsValid) return;

        IsValid = false;
        _errors.AddRange(other.Errors);
    }
}