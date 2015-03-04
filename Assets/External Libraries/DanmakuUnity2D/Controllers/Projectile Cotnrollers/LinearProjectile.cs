using System;
using System.Collections.Generic;
using UnityEngine;

namespace Danmaku2D {
	public class LinearProjectile : ProjectileController, IProjectileGroupController {


		public float Velocity {
			get;
			set;
		}

		public LinearProjectile (float velocity) : base() {
			Velocity = velocity;
		}
		
		#region IProjectileController implementation
		
		public sealed override Vector2 UpdateProjectile (float dt) {
			return UpdateProjectile (Projectile, dt);
		}
		
		#endregion

		#region IProjectileGroupController implementation

		public ProjectileGroup ProjectileGroup {
			get;
			set;
		}

		public virtual Vector2 UpdateProjectile (Projectile projectile, float dt) {
			if (Velocity != 0)
				return projectile.Direction * Velocity * dt;
			else
				return Vector2.zero;
		}

		#endregion
	}
}

