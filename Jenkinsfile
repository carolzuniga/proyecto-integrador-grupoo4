pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                echo "Descargando código desde GitHub..."
                checkout scm
            }
        }

        stage('Build') {
            steps {
                echo "Ejecutando build del proyecto..."
                sh 'echo "Simulando build..."'
            }
        }

        stage('Tests') {
            steps {
                echo "Ejecutando pruebas..."
                sh 'echo "Simulando tests..."'
            }
        }
    }

    post {
        success {
            echo "Pipeline completado correctamente ✔"
        }
        failure {
            echo "Pipeline falló ❌"
        }
    }
}
