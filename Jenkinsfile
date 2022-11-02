pipeline {
environment {
registry = "riya9319147236/jenkins-docker-demo"
registryCredential = 'dockerhub_id'
dockerImage = ''
}
agent any
stages {
stage('Cloning our Git') {
steps {
git url 'https://github.com/riyasingh26/Booking-API.git',branch: 'main'
}
}
stage('Building our image') {
steps{
script {
dockerImage = docker.build registry + ":$BUILD_NUMBER"
}
}
}
stage('Deploy our image') {
steps{
script {
docker.withRegistry( '', registryCredential ) {
dockerImage.push()
}
}
}
}
}
}
