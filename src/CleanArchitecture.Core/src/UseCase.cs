namespace CleanArchitecture.Core;

public abstract class UseCase<ReturnType, ParamsType> {
	public abstract ReturnType Exec(ParamsType parameters);
}