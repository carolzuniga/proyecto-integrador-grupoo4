pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                // Jenkins baja el repo desde GitHub (rama feature/web-ubuntu)
                git branch: 'feature/web-ubuntu',
                    url: 'https://github.com/carolzuniga/proyecto-integrador-grupoo4.git',
                    credentialsId: 'github-token'
            }
        }

        stage('Build') {
            steps {
                echo 'Simulando build PHP...'
            }
        }

        stage('Tests') {
            steps {
                echo 'Simulando tests...'
            }
        }

        stage('Deploy Ubuntu Web') {
            steps {
                echo 'Desplegando en servidor Ubuntu Web (10.50.30.250)...'

                // Jenkins usa su clave SSH (ya configurada) para entrar al servidor
                sh '''
                ssh -o StrictHostKeyChecking=no grupo4@10.50.30.250 \
                  "cd /opt/lampp/htdocs/clientes && git pull origin feature/web-ubuntu"
                '''
            }
        }
    }

    post {
        success {
            echo '✅ Deploy completado correctamente en Ubuntu Web'
        }
        failure {
            echo '❌ Ocurrió un error en el deploy'
        }
    }
}

