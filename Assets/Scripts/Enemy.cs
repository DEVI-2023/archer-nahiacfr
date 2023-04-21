using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Archer
{

    public class Enemy : MonoBehaviour, IScoreProvider
    {

        // Cuántas vidas tiene el enemigo
        [SerializeField]
        private int hitPoints;

        private Animator animator;
        public Vector3 posicion;
        public GameObject enemy;

        public event IScoreProvider.ScoreAddedHandler OnScoreAdded;
        void Start()
        {

            Vector3 posicionEnemigo = new Vector3(UnityEngine.Random.Range(-10, 8), posicion.y, UnityEngine.Random.Range(-10, 8));
            enemy.GetComponent<Rigidbody>().position = posicionEnemigo;
            Debug.Log(posicion);
        }

        void Awake()
        {
            animator = GetComponent<Animator>();

            Vector3 posicionEnemigo = new Vector3(UnityEngine.Random.Range(-10, 8), posicion.y, UnityEngine.Random.Range(-10, 8));
            enemy.GetComponent<Rigidbody>().position = posicionEnemigo;
            Debug.Log(posicion);
        }


        // Método que se llamará cuando el enemigo reciba un impacto
        public void Hit()
        {
         
        }

        private void Die()
        {
           
        }
    }

}