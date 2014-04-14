'case'

class SithInDisguisePresenter
  def initialize(jedi)
    @jedi = jedi
  end

  def alterior_motives
  end
end

class HighCouncilController < ApplicationController
  def index
    @jedi = Jedi.all

    @jedi.map do |jedi|
      prepare_for_meeting(jedi)
    end
  end

  private

  def prepare_for_meeting(jedi)
    if jedi.is_palpatine?
      SithInDisguise.new(jedi)
    else
      jedi
    end
  end
end
