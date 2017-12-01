namespace StateStuff
{
    //clase de estructura de estados, puede ser usada por cualquier character con sus propios estados

    public class StateMachine<X>
    {
        public State<X> currentState { get; private set; }
        public X Enemy;
        

        public StateMachine(X _e)   //que empieze sin estado predeterminado
        {
            Enemy = _e;
            currentState = null;
        }

        public void ChangeState(State<X> _newstate) //pasar de exit a enter al cambiar de estados
        {
            if(currentState != null)                //chequear que este en un estado previamente
                currentState.ExitState(Enemy);
            currentState = _newstate;
            currentState.EnterState(Enemy);
        }

        public void Update()
        {
            if (currentState != null)
                currentState.UpdateState(Enemy);     //chequear antes de actualizar
        }
    }

    public abstract class State<X>  //distintas fases de cada estado
    {
        public abstract void EnterState(X _enemy);

        public abstract void ExitState(X _enemy);

        public abstract void UpdateState(X _enemy);
    }
}