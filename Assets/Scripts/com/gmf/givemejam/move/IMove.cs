using UnityEngine;

namespace com.gmf.givemejam.move
{
	/// <summary>
	/// Interface de comando utilizada por classes de implementaçao
	/// movimentaçao nos objetos do jogo.
	/// </summary>
	public interface IMove
	{
		/// <summary>
		/// Movimento em que o <see cref="IMove"/> ira erxercer sobre o objeto
		/// juntamente com a fisica.
		/// </summary>
		/// <param name="transform"><see cref="Transform"/> com os dados espaciais do objeto.</param>
		/// <param name="rigidbody"><see cref="Rigidbody2D"/> do objeto.</param>
		void FixedMove(Transform transform, Rigidbody2D rigidbody);

		/// <summary>
		/// Movimento em que o <see cref="IMove"/> ira erxercer sobre o objeto.
		/// </summary>
		/// <param name="transform"><see cref="Transform"/> com os dados espaciais do objeto.</param>
		/// <param name="rigidbody"><see cref="Rigidbody2D"/> do alvo.</param>
		void Move(Transform transform, Rigidbody2D rigidbody);
	}
}

