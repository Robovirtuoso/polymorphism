 class HighCouncilController < ApplicationController
  def index
    @jedi = Jedi.all

    @jedi.map do |jedi|
      HighCouncil::Factory.build(jedi)
    end
  end
end
